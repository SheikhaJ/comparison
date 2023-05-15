

def notRepeated(arr):
    for i in range(len(arr)):
        is_repeated = False

        for j in range(len(arr)):
            if i != j and arr[i] == arr[j]:
                is_repeated = True
                break

        if not is_repeated:
            return arr[i]

    return None


arr = [1, 2, 7, 5, 8, 2, 1]
result = notRepeated(arr)
print(result)  
