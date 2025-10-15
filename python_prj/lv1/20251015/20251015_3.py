# PCCE 10번 데이터 분석
# https://school.programmers.co.kr/learn/courses/30/lessons/250121

def solution(data, ext, val_ext, sort_by):
    idx_map = {
        "code":0,
        "date":1,
        "maximum":2,
        "remain":3
    }

    ext_idx = idx_map[ext]
    sort_by_idx = idx_map[sort_by]
    return sorted(
        [item for item in data if item[ext_idx] < val_ext],
        key=lambda x: x[sort_by_idx]
    )

if __name__ == '__main__':

    data = [[1, 20300104, 100, 80], [2, 20300804, 847, 37], [3, 20300401, 10, 8]]
    ext = "date"
    val_ext = 20300501
    sort_by = "remain"

    result = [[3,20300401,10,8],[1,20300104,100,80]]

    if result == solution(data, ext, val_ext, sort_by):
        print(True)
    else:
        print(False)