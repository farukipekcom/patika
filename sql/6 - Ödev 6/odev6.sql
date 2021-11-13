Select AVG(rental_rate) from film
Select COUNT(*) from film where title like 'C%'
Select MAX(length) from film where rental_rate = 0.99
Select count(distinct replacement_cost) from film where length > 150