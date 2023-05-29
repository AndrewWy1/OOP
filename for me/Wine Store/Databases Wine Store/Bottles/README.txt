Two of the most important things about wine are 1) the location it’s made, and 2) who makes it. We’ll use three tables for this information.

First up is the country table. In this simple dictionary, we’ll store a list of UNIQUE country_names. These are countries where we have stores or where wine producers are located.

Next, we need to define regions, i.e. parts of a country. When it comes to wine, regions can be more important than the country of origin. For each region, we’ll store the UNIQUE region_name – country_id pair.

Then there is the producer table. In this table, we’ll store a list of all the wine producers whose wines we stock. For each producer, we’ll define a UNIQUE combination of producer_name – region_id as well as any additional details (if needed).

Wines are also categorized. We’ll store wine categories in the category dictionary. Each record here shall be UNIQUELY defined by its category_name.

We’re finally ready to describe the central table in this subject area: the bottle table. For each type of wine bottle we have, we’ll define:

full_name – The wine’s full name.
category_id – The category of that wine.
label – The complete bottle label text.
volume – How much wine the bottle holds.
producer_id – References the producer of that wine.
year_produced – The year this bottle was produced.
alcohol_percentage – The percentage of alcohol in this wine.
current_price – The current price.
The combination of full_name – producer_id – volume form the UNIQUE/alternate key of this table.
