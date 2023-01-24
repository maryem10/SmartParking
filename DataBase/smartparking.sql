-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mar. 24 jan. 2023 à 14:09
-- Version du serveur : 10.4.24-MariaDB
-- Version de PHP : 8.0.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `smartparking`
--

-- --------------------------------------------------------

--
-- Structure de la table `parking`
--

CREATE TABLE `parking` (
  `id` int(11) NOT NULL,
  `name` varchar(25) NOT NULL,
  `adresse` varchar(25) NOT NULL,
  `contact` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `place`
--

CREATE TABLE `place` (
  `id` int(11) NOT NULL,
  `code` varchar(25) NOT NULL,
  `status` int(11) NOT NULL,
  `type` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `place`
--

INSERT INTO `place` (`id`, `code`, `status`, `type`) VALUES
(18, '1', 1, 'Auto'),
(19, '19', 1, 'Auto'),
(20, '20', 1, 'Auto'),
(21, '21', 1, 'Auto'),
(22, '22', 1, 'Auto'),
(23, '23', 1, 'Auto'),
(24, '24', 1, 'Auto');

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

CREATE TABLE `reservation` (
  `id` int(11) NOT NULL,
  `placeId` int(11) NOT NULL,
  `matricule` varchar(25) NOT NULL,
  `ownername` varchar(25) NOT NULL,
  `model` varchar(25) NOT NULL,
  `type` varchar(11) NOT NULL,
  `prix` double NOT NULL,
  `dateEnreg` date NOT NULL,
  `ownerCin` varchar(25) NOT NULL,
  `status` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `reservation`
--

INSERT INTO `reservation` (`id`, `placeId`, `matricule`, `ownername`, `model`, `type`, `prix`, `dateEnreg`, `ownerCin`, `status`) VALUES
(6, 19, 'MATR1', 'KK', 'MOD1', 'Auto', 3, '2023-01-18', 'HDNJD4', 1),
(7, 20, 'matr', 'yassmina', 'daciaauto', 'Auto', 2, '2023-01-03', 'CIN1922', 1),
(8, 20, 'matr', 'yassmina', 'daciaauto', 'Auto', 2, '2023-01-03', 'CIN1922', 1),
(9, 20, 'matr2', 'yassine', 'fiat', 'velo', 2, '2023-01-18', 'CIN1922', 1),
(10, 18, 'laterc', ',ek', 'hnlz;', 'Auto', 3, '2023-01-18', 'kele', 1);

-- --------------------------------------------------------

--
-- Structure de la table `ticket`
--

CREATE TABLE `ticket` (
  `id` int(11) NOT NULL,
  `idRes` int(11) NOT NULL,
  `idUser` int(11) NOT NULL,
  `dateEmp` date NOT NULL,
  `total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `traçabilité`
--

CREATE TABLE `traçabilité` (
  `id` int(11) NOT NULL,
  `idUser` int(11) NOT NULL,
  `datelogIn` datetime NOT NULL,
  `datelogOut` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `role` varchar(25) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(25) NOT NULL,
  `nom` varchar(25) DEFAULT NULL,
  `prenom` varchar(25) DEFAULT NULL,
  `CIN` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `role`, `username`, `password`, `nom`, `prenom`, `CIN`) VALUES
(1, 'admin', 'ahmed', '1234', 'ahmed', 'alaoui', '455dd'),
(2, 'Bloquer', 'AimraAdmin', 'Aim', '154', 'zzzz', '155'),
(3, 'Bloquer', 'AimraAdmin', 'Aim', '154', 'zzzz', '155');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `parking`
--
ALTER TABLE `parking`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `place`
--
ALTER TABLE `place`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD PRIMARY KEY (`id`),
  ADD KEY `placeId` (`placeId`);

--
-- Index pour la table `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idRes` (`idRes`),
  ADD KEY `idUser` (`idUser`);

--
-- Index pour la table `traçabilité`
--
ALTER TABLE `traçabilité`
  ADD PRIMARY KEY (`id`),
  ADD KEY `foreign_keyUser` (`idUser`);

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `parking`
--
ALTER TABLE `parking`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `place`
--
ALTER TABLE `place`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT pour la table `reservation`
--
ALTER TABLE `reservation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `ticket`
--
ALTER TABLE `ticket`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `traçabilité`
--
ALTER TABLE `traçabilité`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `reservation`
--
ALTER TABLE `reservation`
  ADD CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`placeId`) REFERENCES `place` (`id`);

--
-- Contraintes pour la table `ticket`
--
ALTER TABLE `ticket`
  ADD CONSTRAINT `ticket_ibfk_1` FOREIGN KEY (`idRes`) REFERENCES `reservation` (`id`),
  ADD CONSTRAINT `ticket_ibfk_2` FOREIGN KEY (`idUser`) REFERENCES `user` (`id`);

--
-- Contraintes pour la table `traçabilité`
--
ALTER TABLE `traçabilité`
  ADD CONSTRAINT `foreign_keyUser` FOREIGN KEY (`idUser`) REFERENCES `user` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
