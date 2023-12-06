DROP TABLE IF EXISTS `WebBanHangDemo`.`tb_SystemSetting`;
CREATE TABLE `WebBanHangDemo`.`tb_SystemSetting` (
  `SettingKey` VARCHAR(50) NOT NULL,
  `SettingValue` VARCHAR(4000) NULL,
  `SettingDescrtipion` VARCHAR(250) NULL,
  PRIMARY KEY (`SettingKey`));
