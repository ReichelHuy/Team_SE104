DROP TABLE IF EXISTS `WebBanHangDemo`.`tb_Product`;
CREATE TABLE `WebBanHangDemo`.`tb_Product` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Title` VARCHAR(250) NULL,
  `ProductCategoryID` INT NULL,
  `Description` VARCHAR(4000) NULL,
  `Detail` VARCHAR(4000) NULL,
  `Image` VARCHAR(500) NULL,
  `Price` DECIMAL(18,2) NULL,
  `PriceSale` DECIMAL(18,2) NULL,
  `Quantity` INT NULL,
  `SeoTitle` VARCHAR(250) NULL,
  `SeoDescription` VARCHAR(550) NULL,
  `SeoKeywords` VARCHAR(250) NULL,
  `CreatedDate` DATETIME NULL,
  `CreatedBy` VARCHAR(150) NULL,
  `ModifiedrDate` DATETIME NULL,
  `ModifierBy` VARCHAR(150) NULL,
  PRIMARY KEY (`id`));
  
  
  
