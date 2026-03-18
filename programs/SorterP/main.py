import random

items = []
for i in range(10):
    items.append(random.randint(1, 100))

print("Unsorted: ", items)
items.sort()
print("Sorted: ", items)
