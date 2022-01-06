DROP TABLE products;
DROP TABLE stock_status_types;


CREATE TABLE stock_status_types (
	sid serial PRIMARY KEY,
	name VARCHAR ( 255 ) NOT NULL
);


CREATE TABLE products (
	pid serial PRIMARY KEY,
	
	name VARCHAR ( 255 ) NOT NULL,
	price REAL NOT NULL,
	sid INT NOT NULL,
	
	
	deleted BOOLEAN NOT NULL,	
    updated_at TIMESTAMP NOT NULL,
	CONSTRAINT fk_stock_status_type
      FOREIGN KEY(sid) 
	  REFERENCES stock_status_types(sid),
	
	UNIQUE(name, updated_at)
);


INSERT INTO stock_status_types (name) VALUES ('In stock');
INSERT INTO stock_status_types (name) VALUES ('Out of stock');
INSERT INTO stock_status_types (name) VALUES ('Available for order');
INSERT INTO stock_status_types (name) VALUES ('In provider stock');

INSERT INTO products (name, price, sid, deleted, updated_at) VALUES ('Apple', 10, 1, FALSE, '2022-01-05 17:10:30');
INSERT INTO products (name, price, sid, deleted, updated_at) VALUES ('Apple', 15, 3, FALSE, '2022-01-05 17:11:30');
INSERT INTO products (name, price, sid, deleted, updated_at) VALUES ('Apple', 12, 1, FALSE, '2022-01-05 17:12:30');
INSERT INTO products (name, price, sid, deleted, updated_at) VALUES ('Pear', 20, 2, FALSE, '2022-01-05 17:12:30');




SELECT * FROM stock_status_types;
SELECT * FROM products WHERE name='Apple' ORDER BY updated_at; 


SELECT name, MAX(updated_at) as updated_at  FROM products GROUP BY name

SELECT X.name, X.price, Z.sid, Z.name, X.updated_at  from products as X
INNER JOIN (SELECT name, MAX(updated_at) as updated_at FROM products GROUP BY name) Y ON X.updated_at = Y.updated_at AND X.name = Y.name
INNER JOIN stock_status_types Z ON
X.sid = Z.sid


SELECT P.pid, P.name, P.price, S.sid, S.name, P.deleted, P.updated_at FROM products as P
INNER JOIN (
	SELECT MAX(updated_at) as time FROM 
		(SELECT * FROM products WHERE updated_at <= '2022-01-05 17:11:30' and name='Apple') X) Y 
ON Y.time = P.updated_at
INNER JOIN stock_status_types as S ON S.sid = P.sid
WHERE P.name='Apple'



SELECT P.pid, P.name, P.price, S.sid, S.name, P.deleted, P.updated_at FROM products as P
INNER JOIN(SELECT MAX(updated_at) as time FROM (SELECT * FROM products WHERE updated_at <= '2022-01-05 17:11:30' and name = 'Apple') X) Y
ON Y.time = P.updated_at
INNER JOIN stock_status_types as S
ON S.sid = P.sid
WHERE P.name = 'Apple'

WITH partitions as (
SELECT name, price, updated_at,
case
	when lag(price, 1, '-1'::REAL) OVER (PARTITION BY name ORDER BY updated_at) <> price then 1
	else 0
end as start_partition
FROM products
), 
partitions2 as (SELECT *, SUM(start_partition) OVER(PARTITION BY name ORDER BY updated_at) as partition_number FROM partitions),
partitions3 as (SELECT *, first_value(updated_at) OVER(PARTITION BY name, partition_number ORDER BY updated_at) as begin_date, last_value(updated_at) OVER(PARTITION BY name, partition_number ORDER BY updated_at RANGE BETWEEN UNBOUNDED PRECEDING AND UNBOUNDED FOLLOWING) as end_date FROM partitions2),
mins as (SELECT name, min(price) as price from products group by name),
durations as (SELECT DISTINCT P.name, P.price, P.begin_date, P.end_date, P.end_date - P.begin_date as duration from partitions3 P INNER JOIN mins M on M.price = P.price AND M.name = P.name),
durations2 as (SELECT *, MAX(duration) OVER(PARTITION BY name) = duration as keep from durations)
SELECT * FROM durations2 WHERE keep = true



SELECT name, price, price-lag(price, 1, '0'::REAL) OVER(ORDER BY updated_at) as delta_price, updated_at-lag(updated_at, 1, updated_at) OVER(ORDER BY updated_at) as delta_time, updated_at FROM products WHERE name = 'Apple' ORDER BY updated_at  

