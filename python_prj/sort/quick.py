def swap(arr, i, j):
    arr[i], arr[j] = arr[j], arr[i]

def partition(arr, start, end):
    pivot = arr[(start + end) // 2]
    while start <= end:
        while arr[start] < pivot:
            start += 1
        while arr[end] > pivot:
            end -= 1
        if start <= end:
            swap(arr, start, end)
            start += 1
            end -= 1
    return start

def quick_sort_loop(arr, start, end):
    r_start:int = partition(arr, start, end)
    # 기준의 왼쪽 정렬
    if start < r_start - 1:
        quick_sort_loop(arr, start, r_start - 1)
    # 기준의 오른쪽 정렬
    if end > r_start:
        quick_sort_loop(arr, r_start, end)

def quick_sort(arr):
    quick_sort_loop(arr, 0, len(arr) -1)

if __name__ == "__main__":
    arr = [3,9,4,7,5,0,1,6,8,2]
    print(arr)
    quick_sort(arr)
    print(arr)