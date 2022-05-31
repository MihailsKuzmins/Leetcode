/*
Table Weather
+---------------+---------+
| Column Name   | Type    |
+---------------+---------+
| id            | int     |
| recordDate    | date    |
| temperature   | int     |
+---------------+---------+
id is the primary key for this table.
This table contains information about the temperature on a certain day.

Write an SQL query to find all dates' Id with higher temperatures compared to its previous dates (yesterday).
*/
SELECT
	tblWeather.id
FROM
	Weather AS tblWeather
WHERE
	tblWeather.temperature > (
		SELECT TOP 1
			tblWeatherPrev.temperature
		FROM
			Weather AS tblWeatherPrev
		WHERE
			tblWeatherPrev.recordDate = DATEADD(DAY, -1, tblWeather.recordDate)
	)
