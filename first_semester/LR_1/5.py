#https://acmp.ru/index.asp?main=task&id_task=777

def sdvig(a,k):
      for i in range(k):  
        a = a[-1:] + a[:-1]
      return a
k = int(input())
a = ['G','C','V']
print(*sdvig(a,k), sep ='')
