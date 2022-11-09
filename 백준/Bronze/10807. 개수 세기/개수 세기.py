N = int(input())
a = list(map(int, input().split()))
X = int(input())
count =0
for i in a:
    if i==X:
        count+= 1
        
print(count)