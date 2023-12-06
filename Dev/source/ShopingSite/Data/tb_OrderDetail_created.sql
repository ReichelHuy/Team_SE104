DROP TABLE IF EXISTS `WebBanHangDemo`.`tb_OrderDetail`;
CREATE TABLE `WebBanHangDemo`.`tb_OrderDetail` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `OrderId` INT NULL,
  `ProductId` INT NULL,
  `Price` DECIMAL(18,0) NULL,
  `Quantity` INT NULL,
  PRIMARY KEY (`id`));
