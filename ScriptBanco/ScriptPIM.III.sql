IF EXISTS(SELECT 1 FROM SYSOBJECTS
					WHERE NAME='TB_Login')
					DROP TABLE TB_Login;
GO


IF EXISTS(SELECT 1 FROM SYSOBJECTS
					WHERE NAME='TB_NivelAcesso')
					DROP TABLE TB_NivelAcesso;
GO


IF EXISTS(SELECT 1 FROM SYSOBJECTS
					WHERE NAME='TB_Lote')
					DROP TABLE TB_Lote;
GO


IF EXISTS(SELECT 1 FROM SYSOBJECTS
					WHERE NAME='TB_EntradaEstoque')
					DROP TABLE TB_EntradaEstoque;
GO


IF EXISTS(SELECT 1 FROM SYSOBJECTS
					WHERE NAME='TB_Insumo')
					DROP TABLE TB_Insumo;
GO


IF EXISTS(SELECT 1 FROM SYSOBJECTS
					WHERE NAME='TB_ItemVenda')
					DROP TABLE TB_ItemVenda;
GO


IF EXISTS(SELECT 1 FROM SYSOBJECTS
					WHERE NAME='TB_Venda')
					DROP TABLE TB_Venda;
GO


IF EXISTS(SELECT 1 FROM SYSOBJECTS
					WHERE NAME='TB_Cliente')
					DROP TABLE TB_Cliente;
GO


IF EXISTS(SELECT 1 FROM SYSOBJECTS
					WHERE NAME='TB_Funcionario')
					DROP TABLE TB_Funcionario;
GO


IF EXISTS(SELECT 1 FROM SYSOBJECTS
					WHERE NAME='TB_FichaTecnica')
					DROP TABLE TB_FichaTecnica;
GO


IF EXISTS(SELECT 1 FROM SYSOBJECTS
					WHERE NAME='TB_Produto')
					DROP TABLE TB_Produto;
GO


IF EXISTS(SELECT 1 FROM SYSOBJECTS
					WHERE NAME='TB_Categoria')
					DROP TABLE TB_Categoria;
GO


CREATE TABLE TB_Funcionario
(
	ID_Funcionario INT PRIMARY KEY IDENTITY(1,1),
	NM_Funcionario VARCHAR(50) NOT NULL,
	DS_Sexo VARCHAR(1),
	DT_Nascimento DATE,
	NR_CPF NUMERIC(11) NOT NULL,
	NR_Telefone NUMERIC(11) NOT NULL,
	DS_Email VARCHAR(35),
	NR_CEP VARCHAR(10),
	NM_Rua VARCHAR(50) NOT NULL,
	NR_Casa VARCHAR(5) NOT NULL,
	NM_Bairro VARCHAR(50) NOT NULL,
	DS_Complemento VARCHAR(50),
	NM_Cidade VARCHAR(30),
	DS_UF VARCHAR(2),
	DS_Cargo VARCHAR(30) NOT NULL,
	VL_Salario DECIMAL(7,2) NOT NULL,
	DT_Admissao DATE NOT NULL,
	DT_Demissao DATE NOT NULL,
);
GO


CREATE TABLE TB_NivelAcesso
(
	ID_NivelAcesso INT PRIMARY KEY IDENTITY(1,1),
	DS_NivelAcesso VARCHAR(10) NOT NULL
);
GO


CREATE TABLE TB_Login
(
	ID_Login INT PRIMARY KEY IDENTITY(1,1),
	ID_Funcionario INT NOT NULL,
	ID_NivelAcesso INT NOT NULL,
	NM_Usuario VARCHAR(20) NOT NULL,
	NM_Senha VARCHAR(20) NOT NULL
	FOREIGN KEY (ID_NivelAcesso) REFERENCES TB_NivelAcesso(ID_NivelAcesso),
	FOREIGN KEY (ID_Funcionario) REFERENCES TB_Funcionario(ID_Funcionario)
);
GO


CREATE TABLE TB_Cliente
(
	ID_Cliente INT PRIMARY KEY IDENTITY(1,1),
	NM_Cliente VARCHAR(50) NOT NULL,
	DS_Sexo VARCHAR(1),
	DT_Nascimento DATE,
	NR_CPF NUMERIC(11) NOT NULL,
	NR_Telefone NUMERIC(11) NOT NULL,
	DS_Email VARCHAR(35),
	NR_CEP VARCHAR(10),
	NM_Rua VARCHAR(50) NOT NULL,
	NR_Casa VARCHAR(5) NOT NULL,
	NM_Bairro VARCHAR(50) NOT NULL,
	DS_Complemento VARCHAR(50),
	NM_Cidade VARCHAR(30),
	DS_UF VARCHAR(2),
);
GO


CREATE TABLE TB_Insumo
(
	ID_Insumo INT PRIMARY KEY IDENTITY(1,1),
	NM_Insumo VARCHAR(50) NOT NULL,
	DS_TipoArmazenamento VARCHAR(50) NOT NULL,
	PR_Insumo DECIMAL(7,2) NOT NULL,
	QTDE_Insumo DECIMAL(7,2) NOT NULL,
);
GO


CREATE TABLE TB_EntradaEstoque
(
	ID_EntradaEstoque INT IDENTITY(1,1),
	ID_Insumo INT,
	ID_Funcionario INT NOT NULL,
	DT_Entrada DATE NOT NULL,
	QTDE_InsumoEntrada DECIMAL(7,2) NOT NULL,
	PRIMARY KEY (ID_EntradaEstoque, ID_Insumo),
	FOREIGN KEY (ID_Funcionario) REFERENCES TB_Funcionario(ID_Funcionario)
);
GO


CREATE TABLE TB_Lote
(
	ID_Lote INT IDENTITY(1,1),
	ID_Insumo INT NOT NULL,
	ID_EntradaEstoque INT NOT NULL,
	DT_Vencimento DATE NOT NULL,
	QTDE_Lote DECIMAL(7,2) NOT NULL,
	PRIMARY KEY (ID_Lote, ID_Insumo),
	FOREIGN KEY (ID_EntradaEstoque, ID_Insumo) REFERENCES TB_EntradaEstoque(ID_EntradaEstoque, ID_Insumo)
);
GO


CREATE TABLE TB_Categoria
(
	ID_Categoria INT PRIMARY KEY IDENTITY(1,1),
	NM_Categoria VARCHAR(50) NOT NULL,
	DS_Categoria VARCHAR(150),
);
GO


CREATE TABLE TB_Produto
(
	ID_Produto INT PRIMARY KEY IDENTITY(1,1),
	ID_Categoria INT NOT NULL,
	NM_Produto VARCHAR(50) NOT NULL,
	PR_Unitario DECIMAL(7,2) NOT NULL,
	DS_Produto VARCHAR(150) NOT NULL,
	IMG_Produto IMAGE,
	FOREIGN KEY (ID_Categoria) REFERENCES TB_Categoria(ID_Categoria)
);
GO


CREATE TABLE TB_FichaTecnica
(
	ID_FichaTecnica INT,
	ID_Produto INT,
	ID_EstoqueInsumo INT,
	QTDE_Utilizada DECIMAL(7,2) NOT NULL,
	PRIMARY KEY(ID_FichaTecnica, ID_Produto, ID_EstoqueInsumo)
);


CREATE TABLE TB_Venda
(
	ID_Venda INT PRIMARY KEY IDENTITY(1,1),
	ID_Cliente INT NOT NULL,
	ID_Funcionario INT NOT NULL,
	OBS_Venda VARCHAR(50),
	DT_Venda DATETIME NOT NULL,
	VL_TaxaEntrega DECIMAL(7,2),
	VL_Total DECIMAL(7,2) NOT NULL,
	FOREIGN KEY (ID_Cliente) REFERENCES TB_Cliente(ID_Cliente),
	FOREIGN KEY (ID_Funcionario) REFERENCES TB_Funcionario(ID_Funcionario),
);
GO


CREATE TABLE TB_ItemVenda
(
	ID_Venda INT,
	ID_Produto INT,
	QTDE_ItemVenda INT NOT NULL,
	VL_SubTotal DECIMAL(7,2) NOT NULL,
	PRIMARY KEY (ID_Venda, ID_Produto),
	FOREIGN KEY (ID_Venda) REFERENCES TB_Venda(ID_Venda),
	FOREIGN KEY (ID_Produto) REFERENCES	TB_Produto(ID_Produto)
);
GO