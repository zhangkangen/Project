SELECT * FROM t8


SELECT a=CASE
WHEN a>b THEN a ELSE b
end
,b=CASE
WHEN b>c THEN b ELSE c
END
 FROM t8

 --�ڶ������У�ͳ��ÿ������Ա�������۽��г�����Ա���������۽��ƺţ�>6000���ƣ�>5500����,>4500ͭ�ƣ�������ͨ��

 SELECT * FROM myorders

 SELECT ����Ա,�����۽��=SUM(��������*���ۼ۸�),�ƺ�=
 CASE
	WHEN SUM(��������*���ۼ۸�)>6000 THEN '����'
	WHEN SUM(��������*���ۼ۸�)>5500 THEN '����'
	WHEN SUM(��������*���ۼ۸�)>4500 THEN 'ͭ��'
	ELSE '��ͨ'
 end

 FROM myorders
 GROUP BY ����Ա
 ORDER BY SUM(��������*���ۼ۸�) DESC
 
 SELECT * FROM test

 SELECT number ,����=
 CASE
	WHEN amount>0 THEN amount ELSE 0
	
 END
 ,֧��=
 CASE
	WHEN amount>0 THEN 0
	ELSE ABS(amount)
 END
 FROM test

 SELECT number,����=CASE WHEN amount>0 THEN amount ELSE 0 END,
 ֧��=CASE WHEN amount >0 THEN 0 ELSE -amount END
 FROM test