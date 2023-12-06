DROP TABLE IF EXISTS `WebBanHangDemo`.`tb_Category`;
CREATE TABLE `WebBanHangDemo`.`tb_Category` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Title` VARCHAR(150) NULL,
  `Description` VARCHAR(500) NULL,
  `Position` INT NULL,
  `SeoTitle` VARCHAR(250) NULL,
  `SeoDescription` VARCHAR(550) NULL,
  `SeoKeywords` VARCHAR(250) NULL,
  `CreatedDate` DATETIME NULL,
  `CreatedBy` VARCHAR(150) NULL,
  `ModifiedrDate` DATETIME NULL,
  `ModifierBy` VARCHAR(150) NULL,
  PRIMARY KEY (`id`));
