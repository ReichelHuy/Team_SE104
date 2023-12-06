DROP TABLE IF EXISTS `WebBanHangDemo`.`tb_Post`;
CREATE TABLE `WebBanHangDemo`.`tb_Post` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Title` VARCHAR(250) NULL,
  `CategoryID` INT NULL,
  `Description` VARCHAR(4000) NULL,
  `Detail` VARCHAR(4000) NULL,
  `Image` VARCHAR(500) NULL,
  `SeoTitle` VARCHAR(250) NULL,
  `SeoDescription` VARCHAR(550) NULL,
  `SeoKeywords` VARCHAR(250) NULL,
  `CreatedDate` DATETIME NULL,
  `CreatedBy` VARCHAR(150) NULL,
  `ModifiedrDate` DATETIME NULL,
  `ModifierBy` VARCHAR(150) NULL,
  PRIMARY KEY (`id`));
