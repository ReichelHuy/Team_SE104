DROP TABLE IF EXISTS `WebBanHangDemo`.`tb_Contact`;
CREATE TABLE `WebBanHangDemo`.`tb_Contact` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Name` VARCHAR(150) NULL,
  `Website` VARCHAR(150) NULL,
  `Email` VARCHAR(150) NULL,
  `Message` VARCHAR(4000) NULL,
  `IsRead` BINARY(1) NULL,
  `new_tablecol` VARCHAR(45) NULL,
  `CreatedDate` DATETIME NULL,
  `CreatedBy` VARCHAR(150) NULL,
  `ModifiedrDate` DATETIME NULL,
  `ModifierBy` VARCHAR(150) NULL,
  PRIMARY KEY (`id`));
