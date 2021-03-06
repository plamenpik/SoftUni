CREATE DATABASE exam_prep;

USE exam_prep;

CREATE TABLE `users` (
	`USER_ID` INT(11) NOT NULL AUTO_INCREMENT,
	`USERNAME` VARCHAR(255) NOT NULL,
	`PASSWORD` VARCHAR(255) NOT NULL,
	`FIRST_NAME` VARCHAR(255) NULL DEFAULT NULL,
	`LAST_NAME` VARCHAR(255) NULL DEFAULT NULL,
	PRIMARY KEY (`USER_ID`),
	UNIQUE INDEX `USERNAME` (`USERNAME`)
)
ENGINE=InnoDB
;

CREATE TABLE `categories` (
	`CATEGORY_ID` INT(11) NOT NULL AUTO_INCREMENT,
	`NAME` VARCHAR(50) NOT NULL DEFAULT '0',
	PRIMARY KEY (`CATEGORY_ID`)
)
ENGINE=InnoDB
;

CREATE TABLE `tasks` (
	`TASK_ID` INT(11) NOT NULL AUTO_INCREMENT,
	`TITLE` VARCHAR(50) NOT NULL,
	`DESCRIPTION` TEXT NULL,
	`LOCATION` VARCHAR(100) NULL DEFAULT NULL,
	`USER_ID` INT(11) NOT NULL,
	`CATEGORY_ID` INT(11) NOT NULL,
	`STARTED_ON` DATETIME NOT NULL,
	`DUE_DATE` DATETIME NOT NULL,
	PRIMARY KEY (`TASK_ID`),
	INDEX `FK_tasks_users` (`USER_ID`),
	INDEX `FK_tasks_categories` (`CATEGORY_ID`),
	CONSTRAINT `FK_tasks_categories` FOREIGN KEY (`CATEGORY_ID`) REFERENCES `categories` (`CATEGORY_ID`),
	CONSTRAINT `FK_tasks_users` FOREIGN KEY (`USER_ID`) REFERENCES `users` (`USER_ID`)
)
COLLATE='latin1_swedish_ci'
ENGINE=InnoDB
;

INSERT INTO `categories` (`NAME`) VALUES ('Anniversary');
INSERT INTO `categories` (`NAME`) VALUES ('Birthday');
INSERT INTO `categories` (`NAME`) VALUES ('Business');