SELECT * FROM t8


SELECT a=CASE
WHEN a>b THEN a ELSE b
end
,b=CASE
WHEN b>c THEN b ELSE c
END
 FROM t8

 --在订单表中，统计每个销售员的总销售金额，列出销售员名、总销售金额、称号（>6000金牌，>5500银牌,>4500铜牌，否则普通）

 SELECT * FROM myorders

 SELECT 销售员,总销售金额=SUM(销售数量*销售价格),称号=
 CASE
	WHEN SUM(销售数量*销售价格)>6000 THEN '金牌'
	WHEN SUM(销售数量*销售价格)>5500 THEN '银牌'
	WHEN SUM(销售数量*销售价格)>4500 THEN '铜牌'
	ELSE '普通'
 end

 FROM myorders
 GROUP BY 销售员
 ORDER BY SUM(销售数量*销售价格) DESC
 
 SELECT * FROM test

 SELECT number ,收入=
 CASE
	WHEN amount>0 THEN amount ELSE 0
	
 END
 ,支出=
 CASE
	WHEN amount>0 THEN 0
	ELSE ABS(amount)
 END
 FROM test

 SELECT number,收入=CASE WHEN amount>0 THEN amount ELSE 0 END,
 支出=CASE WHEN amount >0 THEN 0 ELSE -amount END
 FROM test