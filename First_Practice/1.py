#https://acmp.ru/index.asp?main=task&id_task=23

def func(a):
    arr = []
    for i in range(1, a+1):
        if n % i == 0:
            arr.append(i)
    return sum(arr)

n = int(input())
print(func(n))