#compareson between 3 numbers and check the largest number or they are equal
#اكتب برنامج يقارن 3 ارقام ويعطي الرقم الأكبر او يخبر المستخدم في حال تساوي الارقام

#take input from user
a = int(input('a='))
b = int(input('b='))
c = int(input('c='))

#to compare between the inputs
if a == b == c:
    print('The entered numbers are equal')
elif a > b and a > c:
    print(str(a) + ' is the largest')
elif b > a and b > c:
    print(str(b) + ' is the largest')
else:
    print(str(c) + ' is the largest')






