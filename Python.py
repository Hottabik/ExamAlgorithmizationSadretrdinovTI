import random
import datetime
current_date = datetime.date.today()
week_ago = current_date - datetime.timedelta (days=7)
manufacture_date = random.choice([d for d in range (week_ago.toordinal(), current_date.toordinal())])
manufacture_date = datetime.date.fromordinal(manufacture_date)
price = random.randint(1 , 100)
expiration_days =manufacture_date + datetime.timedelta(days=random.randint(1, 7))
if current_date > expiration_days:
    final_price = 0
elif current_date == manufacture_date:
    final_price = price
else:
    final_price = (price * 0.8)
print("изготовления",manufacture_date.strftime("%d.%M.%Y"))

print ("cena",price,"rub");

print("srok", expiration_days,"Dney");

print("cena",final_price,"rub")
