select distinct replacement_cost from film
select COUNT(distinct replacement_cost) from film
select count(*) from film where title like 'T%' and rating = 'G'
select count(*) from country where LENGTH(country) = 5
select count(*) from city where city ilike '%R'