Let’s start with the store table. For each store, we’ll need the UNIQUE combination of the store_name and the city_id where the store is located, plus the store’s physical address, the store’s phone number, the store manager’s mobile number, the store’s email address, and all additional details.

Now we can define an inventory for each store. We’ll use the inventory table for that. Besides the alternate/UNIQUE key (which is composed of the foreign key pair store_id – bottle_id), we’ll record only the current quantity in our inventory.

Before moving on to orders, let’s define the other tables that are referenced in the order table.

First is the supplier table, which contains a list of our suppliers. For each one, we’ll store the UNIQUE supplier_name, the address, all available contact details (phone, mobile, email) and additional details in textual format.

The other table is the employee table. It contains records for all the employees that can log in to the application and take certain actions, e.g. placing orders. Please note that we won’t cover employee roles and permissions in this article. This would make the model too big and detract from the main topic. For each employee, we’ll store:

first_name and last_name – The first and last name of the employee.
username and password – The employee’s login credentials for our application. We’ll store the hash value of the password.
phone and email – The employee’s contact details.
insert_ts – When this record was inserted into the database.
is_active – A flag denoting if this employee is still active within our company.
Orders are made with the intention of having enough bottles in stock to meet customer demands. For each order, we’ll store:

order_number – The UNIQUE identifier we’ll use internally for this order.
expected_delivery_date –The date we expect this order to be filled.
time_placed – The exact time when this order was placed.
time_canceled – The exact time when this order was canceled (in case that happened).
time_delivered – The exact time when this order was delivered (in case that happened).
supplier_id – The ID of the relevant supplier.
store_id – The store where the order should be delivered.
employee_id – The employee who placed this order.
order_price – The price we’ll pay for this order. This value is NULL until the supplier updates it.

The last thing we need to do in this subject area is to define all the items which are part of an order. To do that, we’ll use the order_item table. For each UNIQUE order_id – bottle_id pair, we’ll define the desired quantity and the supplier will update the order_price.