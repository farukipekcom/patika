Select c.city, co.country from city c inner join country co on c.country_id = co.country_id

Select p.payment_id, c.first_name, c.last_name from customer c INNER JOIN payment p on c.customer_id = p.customer_id 

Select r.rental_id, c.first_name, c.last_name from customer c inner join rental r on c.customer_id = r.customer_id 