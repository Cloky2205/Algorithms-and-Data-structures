#https://acmp.ru/index.asp?main=task&id_task=933

a = [int(i) for i in input().split()]
if a[0] >= a[3]:
    print(a[1]*a[3])
elif a[0] < a[3]:
    print((a[3]-a[0])*a[2] + a[0]*a[1])