DROP TABLE IF EXISTS `WebBanHangDemo`.`tb_Order`;
CREATE TABLE `WebBanHangDemo`.`tb_Order` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Code` VARCHAR(50) NULL,
  `CustometName` VARCHAR(150) NULL,
  `Phone` VARCHAR(15) NULL,
  `Address` VARCHAR(500) NULL,
  `TotalAmount` DECIMAL(18,0) NULL,
  `Quantity` INT NULL,
  `CreatedDate` DATETIME NULL,
  `CreatedBy` VARCHAR(150) NULL,
  `ModifiedrDate` DATETIME NULL,
  `ModifierBy` VARCHAR(150) NULL,
  PRIMARY KEY (`id`));