A=int(input())
B=int(input())

B_1 = B-(B//10)*10
B_100 = (B//100)
B_10 = (B-(B_100*100 + B_1))//10

result_1 =  A*B_1
result_2 = A*B_10
result_3 = A*B_100

print(result_1)
print(result_2)
print(result_3)
print(A*B)