$sqlitePath = "D:\Practic\Tema30\Task1\Database\sqlite3.exe"

$dbName = "DBTur_firm.db"

$insertDataSQL = @"
INSERT INTO Туристы (Фамилия, Имя, Отчество) VALUES ('Иванов', 'Иван', 'Иванович');
INSERT INTO Туристы (Фамилия, Имя, Отчество) VALUES ('Петров', 'Петр', 'Петрович');
INSERT INTO Туристы (Фамилия, Имя, Отчество) VALUES ('Сидоров', 'Сидор', 'Сидорович');

INSERT INTO Информация_о_туристах (Код_туриста, Серия_паспорта, Город, Страна, Телефон, Индекс) VALUES (1, '1234', 'Москва', 'Россия', '123-456-7890', 101000);
INSERT INTO Информация_о_туристах (Код_туриста, Серия_паспорта, Город, Страна, Телефон, Индекс) VALUES (2, '5678', 'Санкт-Петербург', 'Россия', '234-567-8901', 102000);
INSERT INTO Информация_о_туристах (Код_туриста, Серия_паспорта, Город, Страна, Телефон, Индекс) VALUES (3, '9012', 'Казань', 'Россия', '345-678-9012', 103000);

INSERT INTO Туры (Название, Цена, Информация) VALUES ('Тур по Золотому кольцу', 15000.00, 'Тур по историческим городам Золотого кольца России');
INSERT INTO Туры (Название, Цена, Информация) VALUES ('Тур в Санкт-Петербург', 20000.00, 'Тур в культурную столицу России');
INSERT INTO Туры (Название, Цена, Информация) VALUES ('Тур в Казань', 18000.00, 'Тур в сердце Татарстана');

INSERT INTO Сезоны (Код_тура, Дата_начала, Дата_конца, Сезон_закрыт, Количество_мест) VALUES (1, '2023-06-01', '2023-08-31', 0, 30);
INSERT INTO Сезоны (Код_тура, Дата_начала, Дата_конца, Сезон_закрыт, Количество_мест) VALUES (2, '2023-07-01', '2023-09-30', 0, 25);
INSERT INTO Сезоны (Код_тура, Дата_начала, Дата_конца, Сезон_закрыт, Количество_мест) VALUES (3, '2023-05-01', '2023-07-31', 0, 20);

INSERT INTO Путевки (Код_туриста, Код_сезона) VALUES (1, 1);
INSERT INTO Путевки (Код_туриста, Код_сезона) VALUES (2, 2);
INSERT INTO Путевки (Код_туриста, Код_сезона) VALUES (3, 3);

INSERT INTO Оплата (Код_путевки, Дата_оплаты, Сумма) VALUES (1, '2023-05-15', 15000.00);
INSERT INTO Оплата (Код_путевки, Дата_оплаты, Сумма) VALUES (2, '2023-06-01', 20000.00);
INSERT INTO Оплата (Код_путевки, Дата_оплаты, Сумма) VALUES (3, '2023-04-20', 18000.00);
"@

& $sqlitePath $dbName "$insertDataSQL"
