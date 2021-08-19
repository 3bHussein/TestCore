use test

SELECT * from Users


go


INSERT into Users (UserName)VALUES('ahmed')
INSERT into Users (UserName)VALUES('ali')
INSERT into Users (UserName)VALUES('mohamed')
INSERT into Users (UserName)VALUES('Hussein')
INSERT into Users (UserName)VALUES('Yahia')
INSERT into Users (UserName)VALUES('Kiro')
INSERT into Users (UserName)VALUES('Hend')
INSERT into Users (UserName)VALUES('saad')
INSERT into Users (UserName)VALUES('sayed')

TRUNCATE TABLE Users

ALTER TABLE Users
DROP COLUMN MyProperty;