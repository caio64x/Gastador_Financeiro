-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.5.5-10.1.19-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              8.0.0.4396
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura do banco de dados para gastadordb
CREATE DATABASE IF NOT EXISTS `gastadordb` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `gastadordb`;


-- Copiando dados para a tabela gastadordb.financeirotipos: 3 rows
DELETE FROM `financeirotipos`;
/*!40000 ALTER TABLE `financeirotipos` DISABLE KEYS */;
INSERT INTO `financeirotipos` (`ID`, `Nome`) VALUES
	(1, 'RECEITA'),
	(2, 'DESPESA FIXA'),
	(3, 'DESPESA VARIÁVEL');
/*!40000 ALTER TABLE `financeirotipos` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

-- Copiando estrutura para tabela gastadordb.financeiros
CREATE TABLE IF NOT EXISTS `financeiros` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDFinanceiroTipo` int(11) NOT NULL,
  `Nome` varchar(50) CHARACTER SET utf8 NOT NULL,
  `Ativo` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Financeiros` (`IDFinanceiroTipo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.


-- Copiando estrutura para tabela gastadordb.mvfinanceiros
CREATE TABLE IF NOT EXISTS `mvfinanceiros` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `IDFinanceiro` int(11) NOT NULL,
  `Pago` char(1) NOT NULL DEFAULT 'N',
  `Descricao` varchar(200) NOT NULL,
  `DataVencimento` date NOT NULL,
  `DataConfirmacao` date DEFAULT NULL,
  `Valor` decimal(18,2) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_MvFinanceiros` (`IDFinanceiro`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.


-- Copiando estrutura para tabela gastadordb.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  `login` varchar(50) NOT NULL,
  `Senha` varchar(50) DEFAULT NULL,
  `Ativo` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- Exportação de dados foi desmarcado.
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
