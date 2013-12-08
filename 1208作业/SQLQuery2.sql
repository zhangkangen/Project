SELECT * FROM users

SELECT * FROM users WHERE loginid='zxh'

SELECT loginpwd,errorcount,DATEDIFF(MINUTE,lastlogintime,GETDATE()) AS diffminute FROM users WHERE loginid='zxh'

UPDATE users SET LastLoginTime=GETDATE() WHERE loginid='zxh'

UPDATE users SET ErrorCount=0 WHERE loginid='zxh'
UPDATE users SET ErrorCount=ErrorCount+1 WHERE loginid='zxh'