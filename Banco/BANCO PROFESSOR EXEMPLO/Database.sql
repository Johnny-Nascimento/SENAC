CREATE DATABASE LojaDB_EXEMPLO;
USE LojaDB_EXEMPLO;
sss
CREATE TABLE Clientes (
    ClienteID INT AUTO_INCREMENT PRIMARY KEY,
    Nome       VARCHAR(100) NOT NULL,
    Cidade     VARCHAR(100),
    Estado     CHAR(2),
    DataCadastro DATE
);

CREATE TABLE Produtos (
    ProdutoID INT AUTO_INCREMENT PRIMARY KEY,
    Nome       VARCHAR(100) NOT NULL,
    Categoria  VARCHAR(50),
    Preco      DECIMAL(10,2) NOT NULL
);

CREATE TABLE Pedidos (
    PedidoID  INT AUTO_INCREMENT PRIMARY KEY,
    ClienteID INT NOT NULL,
    DataPedido DATE,
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID)
);

CREATE TABLE ItensPedido (
    ItemID    INT AUTO_INCREMENT PRIMARY KEY,
    PedidoID  INT NOT NULL,
    ProdutoID INT NOT NULL,
    Quantidade INT NOT NULL,
    PrecoUnit  DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (PedidoID)  REFERENCES Pedidos(PedidoID),
    FOREIGN KEY (ProdutoID) REFERENCES Produtos(ProdutoID)
);

CREATE TABLE Pagamentos (
    PagamentoID INT AUTO_INCREMENT PRIMARY KEY,
    PedidoID    INT NOT NULL,
    DataPagamento DATE,
    Valor       DECIMAL(10,2),
    Metodo      VARCHAR(30),
    FOREIGN KEY (PedidoID) REFERENCES Pedidos(PedidoID)
);
