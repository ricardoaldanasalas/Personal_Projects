# estimated yearly interest
print('How many years will you be saving?')
years = int(input('Enters years: '))

print('How much money is currently in you account?')
principal = float(input('Enter amount in account: '))

print('How much money do you plan on investing montly?')
montly_invest = float(input('Enter amount: '))

print('What do you estimate will be the yearly interest of this investment? ')
interest = float(input('Enter interest in decimal number(10% = 0.1)? '))

print (' ')

montly_invest = montly_invest * 12
final_amount = 0

for i in range(0,years):
    if final_amount == 0:
        final_amount = principal

    final_amount = (final_amount + montly_invest) * (1 + interest)

print ('This is how much you would have in your account after {} years: '.format(years) + str(final_amount))