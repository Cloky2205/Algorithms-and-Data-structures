#https://acmp.ru/index.asp?main=task&id_task=948

k,n = map(int,input().split())
if n % k == 0:
    print((n//k), k)
else:
    print((n//k)+1, n%k)


