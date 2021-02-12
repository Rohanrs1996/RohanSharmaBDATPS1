#!/usr/bin/env python
# coding: utf-8

# In[3]:


#Question 6
def pig(word):
    f_l = word[0]
    r_w = word[1 : ]
    if f_l in('a','e','i','o','u'):
        print (f_l + r_w + "way")
    else:
         print (r_w + f_l+ "ay")


# In[2]:


#Question 7

bloodtype1txt = ['AB','AB','B','O','A','A','AB','O','AB','A','O','O','A','A','A','O','O','O','AB','O','A','A','A','A','A','AB','AB','A','AB','O','AB','O','A','O','O','O','AB','O','AB','AB','AB','A','A']
count = bloodtype1txt.count('AB')
print('the number of people with type AB blood group:', count)
count = bloodtype1txt.count('A')
print('the number of people with type A blood group:', count)
count = bloodtype1txt.count('O')
print('the number of people with type O blood group:', count)
count = bloodtype1txt.count('B')
print('the number of people with type B blood group:', count)


# In[4]:


#Question 9

Trying to add incompatible variables, as in adding 6 + ‘a’   // Can't add int and str together

Referring to the 12th item of a list that has only 10 items  // index error 

Using a value that is out of range for a function’s          // range error
input, such as calling math.sqrt(-1.0)

Using an undeclared variable, such as print(x)               // name error, x is not defined
when x has not been defined

Trying to open a file that does not exist, such as           // get error which  is call no such a file or directory
mistyping the file name or looking in the wrong
directory


# In[25]:


#Question 8

def curconv(exchange,amount):
   infile = open('C:\\Users\\Rohan\\OneDrive\\Documents\\Curriences.txt')
   temp = infile.readlines() 
   for line in temp:
       a = line.split()
       if exchange == a[0]:
           temp3 = amount * float(a[1])
        
   print(temp3)
   infile.close()


# In[24]:


#Question 10

str = 'A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z'
list = [];
def frequencies(str1):
    for n in range(0,length(str1)):
    i = str1.count(n[0])
list.append(i);
return list
print frequencies('apple');


# In[ ]:





# In[ ]:





# In[ ]:





# In[ ]:




