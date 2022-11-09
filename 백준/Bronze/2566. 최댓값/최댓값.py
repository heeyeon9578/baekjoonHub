a = [[0 for col in range(9)] for row in range(9)]
temp=0
b=0
c=0
for i in range(9):
    a[i] = list(map(int, input().split()))
    
for i in range(9):
    for k in range(9):
       if a[i][k] > temp:
           temp=a[i][k]
           b=i
           c=k

print(temp)
print(b+1, c+1)