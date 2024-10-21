#https://acmp.ru/index.asp?main=task&id_task=754

m1,m2,m3 = map(int, input().split())
if m1>727 or m1<94 or m2>727 or m2<94 or m3>727 or m3<94:
    print('Error')
else:
    print(max(m1,m2,m3))
