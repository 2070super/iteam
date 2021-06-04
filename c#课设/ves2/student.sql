/*
Navicat MySQL Data Transfer

Source Server         : demo01
Source Server Version : 80016
Source Host           : localhost:3306
Source Database       : book

Target Server Type    : MYSQL
Target Server Version : 80016
File Encoding         : 65001

Date: 2021-01-05 14:13:38
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `book`
-- ----------------------------
DROP TABLE IF EXISTS `book`;
CREATE TABLE `book` (
  `bid` char(10) NOT NULL,
  `bname` varchar(20) DEFAULT NULL,
  `bauthor` varchar(10) DEFAULT NULL,
  `bpublish` varchar(30) DEFAULT NULL,
  `bnum` int(11) DEFAULT NULL,
  PRIMARY KEY (`bid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- ----------------------------
-- Records of book
-- ----------------------------
INSERT INTO `book` VALUES ('100', '高数', '韦老师', '高等出版社', '3');
INSERT INTO `book` VALUES ('101', '高等代数', '韦老师', '高等出版社', '6');
INSERT INTO `book` VALUES ('102', '线性代数', '韦老师', '清华大学出版社', '4');
INSERT INTO `book` VALUES ('103', '计算方法', '陈老师', '北京大学出版社', '4');

-- ----------------------------
-- Table structure for `borrow`
-- ----------------------------
DROP TABLE IF EXISTS `borrow`;
CREATE TABLE `borrow` (
  `bcid` int(11) NOT NULL AUTO_INCREMENT,
  `sid` char(5) NOT NULL,
  `bid` char(10) NOT NULL,
  `time` date DEFAULT NULL,
  PRIMARY KEY (`bcid`),
  KEY `1` (`sid`),
  KEY `2` (`bid`),
  CONSTRAINT `1` FOREIGN KEY (`sid`) REFERENCES `yonghu` (`yid`),
  CONSTRAINT `2` FOREIGN KEY (`bid`) REFERENCES `book` (`bid`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- ----------------------------
-- Records of borrow
-- ----------------------------

-- ----------------------------
-- Table structure for `manager`
-- ----------------------------
DROP TABLE IF EXISTS `manager`;
CREATE TABLE `manager` (
  `mid` char(5) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `mname` varchar(10) DEFAULT NULL,
  `mpassword` char(10) DEFAULT NULL,
  PRIMARY KEY (`mid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- ----------------------------
-- Records of manager
-- ----------------------------
INSERT INTO `manager` VALUES ('100', '大师', '100');

-- ----------------------------
-- Table structure for `yonghu`
-- ----------------------------
DROP TABLE IF EXISTS `yonghu`;
CREATE TABLE `yonghu` (
  `yid` char(5) NOT NULL,
  `yname` varchar(10) DEFAULT NULL,
  `ypassword` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`yid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- ----------------------------
-- Records of yonghu
-- ----------------------------
INSERT INTO `yonghu` VALUES ('000', '小小怪', '000');
INSERT INTO `yonghu` VALUES ('001', '大大怪', '001');
INSERT INTO `yonghu` VALUES ('002', '开心超人', '002');
