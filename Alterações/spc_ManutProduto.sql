USE [Loja]
GO
/****** Object:  StoredProcedure [dbo].[spc_ManutProduto]    Script Date: 23/10/2015 23:26:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spc_ManutProduto]
	@codigounico	INT,
	@CodProduto		VARCHAR(20),
	@DesProduto		VARCHAR(30),
	@DesLocal		VARCHAR(4),
	@VlrUnitario	FLOAT,
	@QtdProduto		FLOAT,
	@VlrCusto		FLOAT,
	@VlrPercent		FLOAT,
	@EstMinimo		FLOAT,
	@DesFornecedor	VARCHAR(10),
	@CodRefAntiga	VARCHAR(10),
	@VlrUltPreco	FLOAT,
	@NCM			CHAR(8),
	@Imagem			IMAGE = NULL
AS
BEGIN
	SET NOCOUNT ON;

	IF NOT EXISTS (SELECT CodProduto FROM tbl_Produtos WHERE codigounico = @codigounico) BEGIN
		INSERT INTO tbl_Produtos (CodProduto, DesProduto, DesLocal, VlrUnitario, QtdProduto, VlrCusto, 
									VlrPercent, EstMinimo, DatCadastro, DesFornecedor,CodRefAntiga,
									VlrUltPreco, Imagem, NCM)
		VALUES(@CodProduto, @DesProduto, @DesLocal, @VlrUnitario, @QtdProduto, @VlrCusto, @VlrPercent, @EstMinimo,
				CONVERT(VARCHAR(10), GETDATE(), 103), @DesFornecedor, @CodRefAntiga, @VlrUltPreco, @Imagem, @NCM)
	END
	ELSE BEGIN
		
		UPDATE tbl_Produtos
		SET
			CodProduto = @CodProduto,
			DesProduto = @DesProduto,
			DesLocal = @DesLocal,
			VlrUnitario = @VlrUnitario,
			QtdProduto = @QtdProduto,
			VlrCusto = @VlrCusto,
			VlrPercent = @VlrPercent,
			EstMinimo = @EstMinimo,
			DesFornecedor = @DesFornecedor,
			CodRefAntiga = @CodRefAntiga,
			VlrUltPreco = @VlrUltPreco,
			Imagem = @Imagem,
			NCM = @NCM
		WHERE codigounico = @codigounico
		
	END
END

