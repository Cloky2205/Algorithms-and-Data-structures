#https://acmp.ru/index.asp?main=task&id_task=597

r1,r2,r3 = map(int,input().split())
if 2*r1 >= 2*(r2+r3):
    print("YES")
else:
    print("NO")