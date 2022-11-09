a=[0 ]*28
for i in range(28):
    a[i] = int(input())

a.sort()
for i in range(1,31):
    if i not in a:
        print(i)