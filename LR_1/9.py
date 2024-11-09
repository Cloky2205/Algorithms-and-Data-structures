#https://acmp.ru/index.asp?main=task&id_task=907

w,h,r = map(int, input().split())
if w < h:
    if w >= 2*r:
        print('YES')
    else:
        print('NO')
elif h >= 2*r:
    print('YES')
else:
    print('NO')
    