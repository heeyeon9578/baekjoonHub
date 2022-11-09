n, m = map(int, input().split())
a = [[0 for col in range(m)] for row in range(n)]
b = [[0 for col in range(m)] for row in range(n)]
sum=[[0 for col in range(m)] for row in range(n)]

for i in range(n):
    a[i] = list(map(int, input().split()))
    
for i in range(n):
    b[i] = list(map(int, input().split()))
    
for i in range(n):
    for k in range(m):
       sum[i][k] =  a[i][k]+b[i][k]
       
for i in range(len(sum)):            # 세로 크기
    for j in range(len(sum[i])):     # 가로 크기
        print(sum[i][j], end=' ')
    print()