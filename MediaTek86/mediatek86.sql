-- Création de la base de données
CREATE DATABASE IF NOT EXISTS mediatek86 CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE mediatek86;

-- Création de l'utilisateur jfrançois avec mot de passe
CREATE USER IF NOT EXISTS 'jfrançois'@'localhost' IDENTIFIED BY 'j!fr@nçois252065-';

-- Attribution des droits complets à jfrançois sur la base mediatek86
GRANT ALL PRIVILEGES ON mediatek86.* TO 'jfrançois'@'localhost';
FLUSH PRIVILEGES;

-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 29 mai 2025 à 11:50
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--
CREATE DATABASE IF NOT EXISTS `mediatek86` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE `mediatek86`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(23, '2025-05-15 00:00:00', '2025-05-22 00:00:00', 4),
(4, '2024-03-31 00:00:00', '2024-04-11 00:00:00', 1),
(6, '2025-05-22 00:00:00', '2025-05-25 00:00:00', 2),
(9, '2024-08-27 00:00:00', '2024-12-07 00:00:00', 3),
(7, '2024-02-08 00:00:00', '2024-08-21 00:00:00', 4),
(4, '2024-06-16 00:00:00', '2024-08-15 00:00:00', 1),
(5, '2024-08-12 00:00:00', '2024-12-14 00:00:00', 2),
(5, '2024-05-29 00:00:00', '2024-07-06 00:00:00', 3),
(9, '2024-08-02 00:00:00', '2024-09-27 00:00:00', 4),
(9, '2024-05-26 00:00:00', '2024-09-09 00:00:00', 1),
(2, '2024-02-18 00:00:00', '2024-10-30 00:00:00', 2),
(9, '2024-08-24 00:00:00', '2024-11-02 00:00:00', 3),
(10, '2024-04-17 00:00:00', '2024-11-06 00:00:00', 4),
(6, '2024-02-06 00:00:00', '2024-11-14 00:00:00', 1),
(10, '2024-04-26 00:00:00', '2024-06-06 00:00:00', 2),
(9, '2024-06-09 00:00:00', '2024-06-20 00:00:00', 3),
(8, '2024-05-06 00:00:00', '2024-09-02 00:00:00', 4),
(4, '2024-02-22 00:00:00', '2024-11-24 00:00:00', 1),
(9, '2024-04-22 00:00:00', '2024-09-10 00:00:00', 2),
(6, '2024-11-30 00:00:00', '2024-12-10 00:00:00', 3),
(6, '2024-05-08 00:00:00', '2024-08-24 00:00:00', 4),
(7, '2024-04-08 00:00:00', '2024-12-19 00:00:00', 1),
(2, '2024-07-18 00:00:00', '2024-07-26 00:00:00', 2),
(8, '2024-08-12 00:00:00', '2024-12-29 00:00:00', 3),
(6, '2024-01-19 00:00:00', '2024-10-02 00:00:00', 4),
(1, '2024-07-31 00:00:00', '2024-10-23 00:00:00', 1),
(4, '2024-06-08 00:00:00', '2024-10-10 00:00:00', 2),
(4, '2024-02-24 00:00:00', '2024-07-22 00:00:00', 3),
(6, '2024-02-18 00:00:00', '2024-11-05 00:00:00', 4),
(8, '2024-09-01 00:00:00', '2024-09-26 00:00:00', 1),
(7, '2024-01-15 00:00:00', '2024-11-13 00:00:00', 2),
(7, '2024-05-08 00:00:00', '2024-12-19 00:00:00', 1),
(2, '2024-06-18 00:00:00', '2024-07-26 00:00:00', 2),
(10, '2024-04-06 00:00:00', '2024-05-18 00:00:00', 1),
(8, '2024-02-08 00:00:00', '2024-09-21 00:00:00', 3),
(3, '2024-05-02 00:00:00', '2024-09-28 00:00:00', 3),
(3, '2024-04-01 00:00:00', '2024-08-18 00:00:00', 4),
(1, '2024-03-12 00:00:00', '2024-12-27 00:00:00', 1),
(6, '2024-02-24 00:00:00', '2024-06-07 00:00:00', 2),
(8, '2025-05-22 13:43:56', '2025-05-22 13:43:56', 4),
(4, '2024-02-25 00:00:00', '2024-08-06 00:00:00', 4),
(5, '2024-05-05 00:00:00', '2024-10-31 00:00:00', 1),
(5, '2024-05-22 00:00:00', '2024-10-03 00:00:00', 2),
(7, '2024-04-09 00:00:00', '2024-12-20 00:00:00', 1),
(2, '2024-07-19 00:00:00', '2024-07-27 00:00:00', 2),
(8, '2024-08-13 00:00:00', '2024-12-30 00:00:00', 3),
(6, '2024-01-20 00:00:00', '2024-10-03 00:00:00', 4),
(9, '2024-02-24 11:28:30', '2024-07-11 11:28:30', 3),
(4, '2024-06-09 00:00:00', '2024-10-11 00:00:00', 2),
(7, '2024-01-10 00:00:00', '2024-03-15 00:00:00', 1),
(2, '2024-02-05 00:00:00', '2024-03-01 00:00:00', 2),
(8, '2024-03-10 00:00:00', '2024-05-25 00:00:00', 3),
(6, '2024-04-01 00:00:00', '2024-06-10 00:00:00', 4),
(1, '2024-05-05 00:00:00', '2024-07-20 00:00:00', 1),
(4, '2024-06-15 00:00:00', '2024-08-25 00:00:00', 2),
(4, '2024-09-01 00:00:00', '2024-11-15 00:00:00', 3),
(6, '2024-10-05 00:00:00', '2024-12-01 00:00:00', 4),
(8, '2024-11-10 00:00:00', '2025-01-15 00:00:00', 1),
(7, '2024-12-20 00:00:00', '2025-02-28 00:00:00', 2),
(4, '2025-05-21 00:00:00', '2025-05-19 00:00:00', 4),
(23, '2025-03-11 00:00:00', '2025-03-15 00:00:00', 2),
(23, '2025-05-01 00:00:00', '2025-05-08 00:00:00', 2);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Charles', 'Borde', '04 02 22 56 85', 'nullam.feugiat@yahoo.fr', 1),
(2, 'Mathieu', 'Travers', '03 45 53 30 34', 'nulla.dignissim@outlook.fr', 1),
(4, 'Estelle', 'Baardwijk', '04 05 20 22 09', 'tempor.lorem.eget@google.fr', 2),
(5, 'Lucas', 'Artian', '07 76 38 21 80', 'quis.arcu@yahoo.fr', 3),
(6, 'Axel', 'Klein', '05 53 34 24 18', 'vestibulum.mauris@outlook.fr', 3),
(7, 'Clémentine', 'Plourde', '07 72 14 47 10', 'odio.semper.cursus@yahoo.fr', 1),
(8, 'Anaïs', 'Neuville', '04 56 88 21 02', 'pellentesque@google.fr', 1),
(9, 'Mégane', 'Proulx', '04 68 29 33 23', 'ut.odio@google.fr', 2),
(10, 'Lisa', 'Chevalier', '01 26 73 21 97', 'nunc@outlook.fr', 2),
(23, 'Marry', 'Anastasia', '04 52 22 96 63', 'marry-anastasia@gmail.com', 2);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('jfrançois', '8b772b047a4bee0665bd859647e4dda607e2855178b9f77daa004ad07bac914f');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
