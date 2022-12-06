-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.35-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para academia
DROP DATABASE IF EXISTS `academia`;
CREATE DATABASE IF NOT EXISTS `academia` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `academia`;

-- Copiando estrutura para tabela academia.cargos
DROP TABLE IF EXISTS `cargos`;
CREATE TABLE IF NOT EXISTS `cargos` (
  `codCARGO` int(11) NOT NULL AUTO_INCREMENT,
  `tipo` varchar(45) NOT NULL,
  `salario` decimal(10,2) NOT NULL,
  PRIMARY KEY (`codCARGO`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela academia.clientes
DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `codCLIENTES` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `cpf` varchar(45) NOT NULL,
  `dataNascimento` varchar(45) NOT NULL,
  `telefone` varchar(100) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `endereco` varchar(100) DEFAULT NULL,
  `cidade` varchar(100) DEFAULT NULL,
  `PLANOS_codPLANOS` int(11) NOT NULL,
  PRIMARY KEY (`codCLIENTES`,`PLANOS_codPLANOS`),
  KEY `fk_CLIENTES_PLANOS1_idx` (`PLANOS_codPLANOS`),
  CONSTRAINT `fk_CLIENTES_PLANOS1` FOREIGN KEY (`PLANOS_codPLANOS`) REFERENCES `planos` (`codPLANOS`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela academia.equipamentos
DROP TABLE IF EXISTS `equipamentos`;
CREATE TABLE IF NOT EXISTS `equipamentos` (
  `codEQUIPAMENTOS` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `descricao` varchar(300) DEFAULT NULL,
  `FORNECEDORES_codFORNECEDORES` int(11) NOT NULL,
  PRIMARY KEY (`codEQUIPAMENTOS`,`FORNECEDORES_codFORNECEDORES`),
  KEY `fk_EQUIPAMENTOS_FORNECEDORES1_idx` (`FORNECEDORES_codFORNECEDORES`),
  CONSTRAINT `fk_EQUIPAMENTOS_FORNECEDORES1` FOREIGN KEY (`FORNECEDORES_codFORNECEDORES`) REFERENCES `fornecedores` (`codFORNECEDORES`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela academia.fornecedores
DROP TABLE IF EXISTS `fornecedores`;
CREATE TABLE IF NOT EXISTS `fornecedores` (
  `codFORNECEDORES` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `cnpj` varchar(45) NOT NULL,
  `telefone` varchar(45) NOT NULL,
  `email` varchar(100) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  PRIMARY KEY (`codFORNECEDORES`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela academia.funcionarios
DROP TABLE IF EXISTS `funcionarios`;
CREATE TABLE IF NOT EXISTS `funcionarios` (
  `codFUNCIONARIOS` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `cpf` varchar(45) NOT NULL,
  `dataNascimento` date NOT NULL,
  `telefone` varchar(45) NOT NULL,
  `email` varchar(100) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `cidade` varchar(100) NOT NULL,
  `carteiraTrabalho` varchar(45) NOT NULL,
  `dataAdmissao` date NOT NULL,
  `dataDemissao` date DEFAULT NULL,
  `CARGO_codCARGO` int(11) NOT NULL,
  PRIMARY KEY (`codFUNCIONARIOS`,`CARGO_codCARGO`),
  KEY `fk_FUNCIONARIOS_CARGO1_idx` (`CARGO_codCARGO`),
  CONSTRAINT `fk_FUNCIONARIOS_CARGO1` FOREIGN KEY (`CARGO_codCARGO`) REFERENCES `cargos` (`codCARGO`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela academia.itemvenda
DROP TABLE IF EXISTS `itemvenda`;
CREATE TABLE IF NOT EXISTS `itemvenda` (
  `PRODUTOS_codPRODUTOS` int(11) NOT NULL,
  `VENDAS_codVENDA` int(11) NOT NULL,
  `quantidade` decimal(10,0) NOT NULL,
  PRIMARY KEY (`PRODUTOS_codPRODUTOS`,`VENDAS_codVENDA`),
  KEY `fk_PRODUTOS_has_VENDAS_VENDAS1_idx` (`VENDAS_codVENDA`),
  KEY `fk_PRODUTOS_has_VENDAS_PRODUTOS1_idx` (`PRODUTOS_codPRODUTOS`),
  CONSTRAINT `fk_PRODUTOS_has_VENDAS_PRODUTOS1` FOREIGN KEY (`PRODUTOS_codPRODUTOS`) REFERENCES `produtos` (`codPRODUTOS`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_PRODUTOS_has_VENDAS_VENDAS1` FOREIGN KEY (`VENDAS_codVENDA`) REFERENCES `vendas` (`codVENDA`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela academia.planos
DROP TABLE IF EXISTS `planos`;
CREATE TABLE IF NOT EXISTS `planos` (
  `codPLANOS` int(11) NOT NULL AUTO_INCREMENT,
  `dataInicio` varchar(50) NOT NULL,
  `dataVencimento` varchar(50) DEFAULT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  `tipoPlano` varchar(45) NOT NULL,
  PRIMARY KEY (`codPLANOS`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para procedure academia.proc_alteraCargos
DROP PROCEDURE IF EXISTS `proc_alteraCargos`;
DELIMITER //
CREATE PROCEDURE `proc_alteraCargos`(in codigoCargos int, in novoNomeCargo varchar(45), in novoSalarioCargo decimal(10,2))
BEGIN
update cargos set  tipo = novoNomeCargo, salario = novoSalarioCargo  where codCargo = codigoCargos;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_alteraClientes
DROP PROCEDURE IF EXISTS `proc_alteraClientes`;
DELIMITER //
CREATE PROCEDURE `proc_alteraClientes`(in codigoClientes int, in nomeCliente varchar(100), in cpfCliente varchar(45), in dataNascimentoCliente VARCHAR(45), in telCliente varchar(100), 
in emailCliente varchar(100), in  enderecoCliente varchar(100), in cidadeCliente varchar(100), in codigoPlano int)
BEGIN
update clientes set  nome = nomeCliente, cpf = cpfCliente, dataNascimento = dataNascimentoCliente,  
telefone = telCliente, email = emailCliente, endereco = enderecoCliente, cidade = cidadeCliente, PLANOS_codPLANOS = codigoPlano
where codCLIENTES = codigoClientes;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_alteraEquipamentos
DROP PROCEDURE IF EXISTS `proc_alteraEquipamentos`;
DELIMITER //
CREATE PROCEDURE `proc_alteraEquipamentos`(in codigoEquipamento int, in nomeEquipamento varchar(100), in descricaoEquipamento varchar(300), in codigoFornecedor int)
BEGIN
update equipamentos set nome = nomeEquipamento, descricao = descricaoEquipamento, FORNECEDORES_codFORNECEDORES = codigoFornecedor where codEQUIPAMENTOS = codigoEquipamento;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_alteraFornecedores
DROP PROCEDURE IF EXISTS `proc_alteraFornecedores`;
DELIMITER //
CREATE PROCEDURE `proc_alteraFornecedores`(in codigoFornecedores int, in novoNomeFornecedor varchar(100), in novoCnpjFornecedor varchar(45), in novoTelefoneFornecedor varchar(45),
in novoEmailFornecedor varchar(100), in novoEnderecoFornecedor varchar(100))
BEGIN
update fornecedores set nome = novoNomeFornecedor, cnpj = novoCnpjFornecedor, telefone = novoTelefoneFornecedor,
email = novoEmailFornecedor, endereco = novoEnderecoFornecedor where codFornecedores = codigoFornecedores;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_alteraFuncionarios
DROP PROCEDURE IF EXISTS `proc_alteraFuncionarios`;
DELIMITER //
CREATE PROCEDURE `proc_alteraFuncionarios`(in codigoFuncionarios int, in nomeFuncionario varchar(100), in cpfFuncionario varchar(45), in dataNascimentoFuncionario date, in telefoneFuncionario varchar(45),
in emailFuncionario varchar(100), in enderecoFuncionario varchar(100), in cidadeFuncionario varchar(100), carteiraTrabalhoFuncionario varchar(45), in dataAdmissaoFuncionario date, in dataDemissaoFuncionario date, in codigoCargo int)
BEGIN
update funcionarios set nome = nomeFuncionario, cpf = cpfFuncionario, dataNascimento = dataNascimentoFuncionario, telefone = telefoneFuncionario, 
email = emailFuncionario, endereco = enderecoFuncionario, cidade = cidadeFuncionario, carteiraTrabalho = carteiraTrabalhoFuncionario,
dataAdmissao = dataAdmissaoFuncionario, dataDemissao = dataDemissaoFuncionario, CARGO_codCARGO = codigoCargo where codFUNCIONARIOS = codigoFuncionarios;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_alteraPlanos
DROP PROCEDURE IF EXISTS `proc_alteraPlanos`;
DELIMITER //
CREATE PROCEDURE `proc_alteraPlanos`(in codigoPlanos int, in dataInicioPlano date, in dataVencimentoPlano date, in valorPlano decimal (10,2), in novoTipoPlano varchar(45))
BEGIN
update planos set dataInicio = dataInicioPlano, dataVencimento = dataVencimentoPlano, valor = valorPlano,
tipoPlano = novoTipoPlano where codPLANOS = codigoPlanos;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_alteraProdutos
DROP PROCEDURE IF EXISTS `proc_alteraProdutos`;
DELIMITER //
CREATE PROCEDURE `proc_alteraProdutos`(in codigoProdutos int, in nomeProduto varchar(100), in precoCustoProduto decimal(10,2), in precoVendaProduto decimal(10,2),
in margemLucroProduto decimal(5,2), in dataValidadeProduto date, in quantidadeEstoqueProduto decimal(10,2), in codigoFornecedor int)
BEGIN
update produtos set nome = nomeProduto, precoCusto = precoCustoProduto, precoVenda = precoVendaProduto, margemLucro = margemLucroProduto, 
dataValidade = dataValidadeProduto, quantidadeEstoque = quantidadeEstoqueProduto, FORNECEDORES_codFORNECEDORES = codigoFornecedor where codPRODUTOS = codigoProdutos;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_alteraVendas
DROP PROCEDURE IF EXISTS `proc_alteraVendas`;
DELIMITER //
CREATE PROCEDURE `proc_alteraVendas`(in codigo int, in dataDaVenda datetime, in descontoDavenda decimal(5,2),in tipoDaVenda ENUM('À vista', 'Cartão Débito', 'Cartão Crédito', 'PIX'), 
in codigoDoCliente int, in codigoDoPlano int, in codigoDoFuncionario int)
BEGIN
update vendas set dataHora = dataDaVenda, desconto = descontoDavenda, tipoVenda = tipoDaVenda, CLIENTES_codCLIENTES = codigoDoCliente, CLIENTES_PLANOS_codPLANOS = codigoDoPlano, 
FUNCIONARIOS_codFUNCIONARIOS = codigoDoFuncionario where codVENDA = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_deleteCargos
DROP PROCEDURE IF EXISTS `proc_deleteCargos`;
DELIMITER //
CREATE PROCEDURE `proc_deleteCargos`(in codigoCargo int)
BEGIN
delete from cargos where codCargo = codigoCargo;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_deleteClientes
DROP PROCEDURE IF EXISTS `proc_deleteClientes`;
DELIMITER //
CREATE PROCEDURE `proc_deleteClientes`(in codigoClientes int)
BEGIN
delete from clientes where codCLIENTES = codigoClientes;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_deleteEquipamentos
DROP PROCEDURE IF EXISTS `proc_deleteEquipamentos`;
DELIMITER //
CREATE PROCEDURE `proc_deleteEquipamentos`(in codigoEquipamentos int)
BEGIN
delete from equipamentos where codEQUIPAMENTOS = codigoEquipamentos;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_deleteFornecedores
DROP PROCEDURE IF EXISTS `proc_deleteFornecedores`;
DELIMITER //
CREATE PROCEDURE `proc_deleteFornecedores`(in codigoFornecedor int)
BEGIN
delete from fornecedores where codFORNECEDORES = codigoFornecedor;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_deleteFuncionarios
DROP PROCEDURE IF EXISTS `proc_deleteFuncionarios`;
DELIMITER //
CREATE PROCEDURE `proc_deleteFuncionarios`(in codigoFuncionarios int)
BEGIN
delete from funcionarios where codFUNCIONARIOS = codigoFuncionarios;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_deletePlanos
DROP PROCEDURE IF EXISTS `proc_deletePlanos`;
DELIMITER //
CREATE PROCEDURE `proc_deletePlanos`(in codigoPlanos int)
BEGIN
delete from planos where codPLANOS = codigoPlanos;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_deleteProdutos
DROP PROCEDURE IF EXISTS `proc_deleteProdutos`;
DELIMITER //
CREATE PROCEDURE `proc_deleteProdutos`(in codigoProdutos int)
BEGIN
delete from produtos where codPRODUTOS = codigoProdutos;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_deleteVendas
DROP PROCEDURE IF EXISTS `proc_deleteVendas`;
DELIMITER //
CREATE PROCEDURE `proc_deleteVendas`(in codigo int)
BEGIN
delete from vendas where codVENDA = codigo;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_insereCargos
DROP PROCEDURE IF EXISTS `proc_insereCargos`;
DELIMITER //
CREATE PROCEDURE `proc_insereCargos`(in nomeTipoCargo varchar(45),in salarioTipoCargo decimal(10,2))
BEGIN
insert into cargos values(null, nomeTipoCargo, salarioTipoCargo);
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_insereClientes
DROP PROCEDURE IF EXISTS `proc_insereClientes`;
DELIMITER //
CREATE PROCEDURE `proc_insereClientes`( in nomeCliente varchar(100), in cpfCliente varchar(45), in dataNascimentoCliente varchar(45), in telCliente varchar(100), 
in emailCliente varchar(100), in  enderecoCliente varchar(100), in cidadeCliente varchar(100), in codigoPlano int)
BEGIN
insert into clientes values(null,nomeCliente,cpfCliente,dataNascimentoCliente,telCliente,emailCliente,enderecoCliente,cidadeCliente, codigoPlano);
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_insereEquipamentos
DROP PROCEDURE IF EXISTS `proc_insereEquipamentos`;
DELIMITER //
CREATE PROCEDURE `proc_insereEquipamentos`(in nomeDoEquipamento varchar(100), in descricaoEquipamento varchar(300), in codigoFornecedor int)
BEGIN
insert into equipamentos(codEQUIPAMENTOS, nome, descricao, FORNECEDORES_codFORNECEDORES) values (null, nomeDoEquipamento,  descricaoEquipamento, codigoFornecedor);
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_insereFornecedores
DROP PROCEDURE IF EXISTS `proc_insereFornecedores`;
DELIMITER //
CREATE PROCEDURE `proc_insereFornecedores`(in nomeFornecedor varchar(100), in cnpjFornecedor varchar(45), in telefoneFornecedor varchar(45), in emailFornecedor varchar(100), in enderecoFornecedor varchar(100))
BEGIN
insert into fornecedores values(null, nomeFornecedor, cnpjFornecedor, telefoneFornecedor, emailFornecedor, enderecoFornecedor);
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_insereFuncionarios
DROP PROCEDURE IF EXISTS `proc_insereFuncionarios`;
DELIMITER //
CREATE PROCEDURE `proc_insereFuncionarios`(in nomeFuncionario varchar(100), in cpfFuncionario varchar(45), in dataNascimentoFuncionario date, in telFuncionario varchar(100), 
in emailFuncionario varchar(100), in  enderecoFuncionario varchar(100), in cidadeFuncionario varchar(100), in carteiraTrabalhoFuncionario varchar(45),in dataAdmissaoFuncionario date, in dataDemissaoFuncionario date, in codigoCargo int)
BEGIN
insert into funcionarios(codFUNCIONARIOS, nome, cpf, dataNascimento, telefone, email, endereco, cidade, carteiraTrabalho, dataAdmissao, dataDemissao, CARGO_codCargo) values(null,nomeFuncionario, cpfFuncionario, 
dataNascimentoFuncionario, telFuncionario, emailFuncionario, enderecoFuncionario, cidadeFuncionario, carteiraTrabalhoFuncionario, dataAdmissaoFuncionario, dataDemissaoFuncionario, codigoCargo);
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_inserePlanos
DROP PROCEDURE IF EXISTS `proc_inserePlanos`;
DELIMITER //
CREATE PROCEDURE `proc_inserePlanos`(in dataInicioPlano varchar(45), in dataFimPlano varchar(45), in valorPlano decimal(10,2), in tipoPlanoCliente varchar(45))
BEGIN
insert into planos values(null,dataInicioPlano,dataFimPlano,valorPlano,tipoPlanoCliente);
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_insereProdutos
DROP PROCEDURE IF EXISTS `proc_insereProdutos`;
DELIMITER //
CREATE PROCEDURE `proc_insereProdutos`(in nomeProduto varchar(100), in precoCustoProduto decimal(10,2), in precoVendaProduto decimal(10,2), in valorLucro decimal(5,2), in dataValidadeProduto date, 
in quatidadeProdutosEmEstoque decimal(10,2), in codigoFornecedor int)
BEGIN
insert into produtos(codPRODUTOS, nome, precoCusto, precoVenda, FORNECEDORES_codFORNECEDORES) values(null, nomeProduto, precoCustoProduto, precoVendaProduto, codigoFornecedor); 
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_insereVendas
DROP PROCEDURE IF EXISTS `proc_insereVendas`;
DELIMITER //
CREATE PROCEDURE `proc_insereVendas`(in dataDaVenda datetime, in descontoDavenda decimal(5,2),in tipoDaVenda ENUM('À vista', 'Cartão Débito', 'Cartão Crédito', 'PIX'), 
in codigoDoCliente int, in codigoDoPlano int, in codigoDoFuncionario int)
BEGIN
insert into vendas(codVENDA,dataHora,desconto,tipoVenda,CLIENTES_codCLIENTES,CLIENTES_PLANOS_codPLANOS,FUNCIONARIOS_codFUNCIONARIOS) values (null,dataDaVenda,descontoDavenda,tipoDaVenda,codigoDoCliente,codigoDoPlano,codigoDoFuncionario);
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_listaClientes
DROP PROCEDURE IF EXISTS `proc_listaClientes`;
DELIMITER //
CREATE PROCEDURE `proc_listaClientes`()
BEGIN
select codCLIENTES, nome, cpf, dataNascimento, telefone, email, endereco, cidade, planos.tipoPlano
from clientes
inner join planos on clientes.PLANOS_codPLANOS = planos.codPlanos;
END//
DELIMITER ;

-- Copiando estrutura para procedure academia.proc_listaPlanos
DROP PROCEDURE IF EXISTS `proc_listaPlanos`;
DELIMITER //
CREATE PROCEDURE `proc_listaPlanos`()
BEGIN
select * from planos;
END//
DELIMITER ;

-- Copiando estrutura para tabela academia.produtos
DROP TABLE IF EXISTS `produtos`;
CREATE TABLE IF NOT EXISTS `produtos` (
  `codPRODUTOS` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `precoCusto` decimal(10,2) NOT NULL,
  `precoVenda` decimal(10,2) NOT NULL,
  `margemLucro` decimal(5,2) DEFAULT NULL,
  `dataValidade` date DEFAULT NULL,
  `quantidadeEstoque` decimal(10,2) DEFAULT NULL,
  `FORNECEDORES_codFORNECEDORES` int(11) NOT NULL,
  PRIMARY KEY (`codPRODUTOS`,`FORNECEDORES_codFORNECEDORES`),
  KEY `fk_PRODUTOS_FORNECEDORES1_idx` (`FORNECEDORES_codFORNECEDORES`),
  CONSTRAINT `fk_PRODUTOS_FORNECEDORES1` FOREIGN KEY (`FORNECEDORES_codFORNECEDORES`) REFERENCES `fornecedores` (`codFORNECEDORES`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

-- Copiando estrutura para tabela academia.vendas
DROP TABLE IF EXISTS `vendas`;
CREATE TABLE IF NOT EXISTS `vendas` (
  `codVENDA` int(11) NOT NULL AUTO_INCREMENT,
  `dataHora` datetime NOT NULL,
  `desconto` decimal(5,2) DEFAULT NULL,
  `tipoVenda` enum('À vista','Cartão Débito','Cartão Crédito','PIX') NOT NULL,
  `CLIENTES_codCLIENTES` int(11) NOT NULL,
  `CLIENTES_PLANOS_codPLANOS` int(11) NOT NULL,
  `FUNCIONARIOS_codFUNCIONARIOS` int(11) NOT NULL,
  PRIMARY KEY (`codVENDA`,`CLIENTES_codCLIENTES`,`CLIENTES_PLANOS_codPLANOS`,`FUNCIONARIOS_codFUNCIONARIOS`),
  KEY `fk_VENDAS_CLIENTES1_idx` (`CLIENTES_codCLIENTES`,`CLIENTES_PLANOS_codPLANOS`),
  KEY `fk_VENDAS_FUNCIONARIOS1_idx` (`FUNCIONARIOS_codFUNCIONARIOS`),
  CONSTRAINT `fk_VENDAS_CLIENTES1` FOREIGN KEY (`CLIENTES_codCLIENTES`) REFERENCES `clientes` (`codCLIENTES`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_VENDAS_FUNCIONARIOS1` FOREIGN KEY (`FUNCIONARIOS_codFUNCIONARIOS`) REFERENCES `funcionarios` (`codFUNCIONARIOS`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Exportação de dados foi desmarcado.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
