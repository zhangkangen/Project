SELECT * FROM users
SELECT loginpwd,errorCount,DATEDIFF(MINUTE,lastloginTime,GETDATE()) AS diffMinute FROM users WHERE loginid='zxh'
SELECT * FROM users
update users set errorcount=0 where loginid='zxh'
update users set lastlogintime=getdate() where loginid='zxh'
update users set errorcount=errorcount+1 where loginid='zxh'
update users set errorcount=0 where loginid='zxh'
update users set lastlogintime=getdate() where loginid='nll'

