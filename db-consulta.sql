-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 11-Out-2022 às 06:26
-- Versão do servidor: 10.4.22-MariaDB
-- versão do PHP: 7.3.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `fmq_db`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `pessoa`
--

CREATE TABLE `pessoa` (
  `PESSOA_ID` bigint(11) NOT NULL,
  `NOME_FANTASIA` varchar(255) NOT NULL,
  `CNPJ_CPF` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `pessoa`
--

INSERT INTO `pessoa` (`PESSOA_ID`, `NOME_FANTASIA`, `CNPJ_CPF`) VALUES
(0, 'Leandro Danilo da Luz', '683.382.068-65'),
(1, 'Sônia Giovana Cecília Ramos', '405.296.641-43'),
(2, 'Thiago Felipe Enrico Brito', '951.595.538-60'),
(3, 'Diogo Anthony Ribeiro', '397.674.400-03'),
(4, 'Mariane Letícia Lara Alves', '073.683.239-40'),
(5, 'Filipe Carlos Eduardo Vieira', '019.495.514-15'),
(6, 'Rita Natália Flávia Sales', '045.271.851-10'),
(7, 'Daniela Bruna Alice Carvalho', '320.837.875-01'),
(8, 'Mariah Vanessa Rita Barbosa', '352.258.185-79'),
(9, 'Samuel Pedro Henrique da Mata', '748.086.854-50'),
(10, 'Erick Ryan Nunes', '767.790.896-99');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `pessoa`
--
ALTER TABLE `pessoa`
  ADD PRIMARY KEY (`PESSOA_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
