-- --------------------------------------------------------
-- Hôte :                        127.0.0.1
-- Version du serveur:           10.4.10-MariaDB - mariadb.org binary distribution
-- SE du serveur:                Win64
-- HeidiSQL Version:             11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Listage de la structure de la base pour ava
CREATE DATABASE IF NOT EXISTS `ava` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `ava`;

-- Listage de la structure de la table ava. activité
CREATE TABLE IF NOT EXISTS `activité` (
  `ID_ACT` int(1) NOT NULL AUTO_INCREMENT,
  `ID_TC` char(8) NOT NULL,
  `CD_UTI` char(8) NOT NULL,
  `NOM_ACT` char(32) DEFAULT NULL,
  `DATE_ACT` char(10) DEFAULT NULL,
  `DATE_FIN_ACT` char(10) DEFAULT NULL,
  PRIMARY KEY (`ID_ACT`),
  KEY `I_FK_ACTIVITÉ_TYPE_ACTIVITÉ` (`ID_TC`),
  KEY `I_FK_ACTIVITÉ_UTILISATEUR` (`CD_UTI`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Les données exportées n'étaient pas sélectionnées.

-- Listage de la structure de la table ava. reservation
CREATE TABLE IF NOT EXISTS `reservation` (
  `ID_RESA` int(11) NOT NULL,
  `ID_ACT` char(8) NOT NULL,
  `CD_UTI` char(8) NOT NULL,
  `DATE_RESA` date DEFAULT NULL,
  PRIMARY KEY (`ID_RESA`),
  KEY `I_FK_RESERVATION_ACTIVITÉ` (`ID_ACT`),
  KEY `I_FK_RESERVATION_UTILISATEUR` (`CD_UTI`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Les données exportées n'étaient pas sélectionnées.

-- Listage de la structure de la table ava. type_activité
CREATE TABLE IF NOT EXISTS `type_activité` (
  `ID_TC` char(8) NOT NULL,
  `NOM_TC` char(32) DEFAULT NULL,
  PRIMARY KEY (`ID_TC`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Les données exportées n'étaient pas sélectionnées.

-- Listage de la structure de la table ava. utilisateur
CREATE TABLE IF NOT EXISTS `utilisateur` (
  `CD_UTI` char(8) NOT NULL,
  `MDP` char(32) DEFAULT NULL,
  `NOM` char(32) DEFAULT NULL,
  `PRENOM` char(32) DEFAULT NULL,
  `SEXE` char(10) DEFAULT NULL,
  `TYPEUTI` char(1) DEFAULT NULL,
  `DATE_NAISSANCE` char(15) DEFAULT NULL,
  PRIMARY KEY (`CD_UTI`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- Les données exportées n'étaient pas sélectionnées.

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
