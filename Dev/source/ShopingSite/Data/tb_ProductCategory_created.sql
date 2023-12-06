DROP TABLE IF EXISTS `WebBanHangDemo`.`tb_ProductCategory`;
CREATE TABLE `WebBanHangDemo`.`tb_ProductCategory` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Title` VARCHAR(150) NULL,
  `Description` VARCHAR(500) NULL,
  `Icon` VARCHAR(500) NULL,
  `CreatedDate` DATETIME NULL,
  `CreatedBy` VARCHAR(150) NULL,
  `ModifiedrDate` DATETIME NULL,
  `ModifierBy` VARCHAR(150) NULL,
  PRIMARY KEY (`id`));
