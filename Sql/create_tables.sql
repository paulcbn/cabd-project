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


SELECT name, MAX(updated_at) as updated_at  FROM products GROUP BY name

SELECT X.name, X.price, Z.sid, Z.name, X.updated_at  from products as X
INNER JOIN (SELECT name, MAX(updated_at) as updated_at FROM products GROUP BY name) Y ON X.updated_at = Y.updated_at AND X.name = Y.name
INNER JOIN stock_status_types Z ON
X.sid = Z.sid


SELECT * FROM products
INNER JOIN (SELECT MAX(updated_at) FROM (SELECT * FROM products WHERE updated_at <= '2022-01-05 17:11:30' and name='Apple') X) Y ON Y.max = updated_at
WHERE name='Apple'

