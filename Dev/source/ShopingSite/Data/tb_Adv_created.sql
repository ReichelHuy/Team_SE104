DROP TABLE IF EXISTS `WebBanHangDemo`.`tb_Adv`;
CREATE TABLE `WebBanHangDemo`.`tb_Adv` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Title` VARCHAR(250) NULL,
  `Description` VARCHAR(500) NULL,
  `Image` VARCHAR(500) NULL,
  `Type` INT NULL,
  `Link` VARCHAR(500) NULL,
  `CreatedDate` DATETIME NULL,
  `CreatedBy` VARCHAR(150) NULL,
  `ModifiedrDate` DATETIME NULL,
  `ModifierBy` VARCHAR(150) NULL,
  PRIMARY KEY (`id`));
