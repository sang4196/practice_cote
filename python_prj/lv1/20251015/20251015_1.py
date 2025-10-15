# PCCP 1번 붕대 감기
# https://school.programmers.co.kr/learn/courses/30/lessons/250137

def solution(bandage, health, attacks):
    answer = 0

    cast_time = bandage[0]                  # 시전 시간
    healing_amount = bandage[1]             # 초당 회복량
    additional_healing_amount = bandage[2]  # 추가 회복량

    current_health = health
    start_time = 1

    for time, damage in attacks:
        healing_point = ((time - start_time) * healing_amount +                         # 힐
                         (time - start_time) // cast_time * additional_healing_amount)  # 추가힐
        current_health += healing_point
        # 보정
        if current_health >= health:
            current_health = health

        current_health -= damage
        if current_health <= 0:
            break

        start_time = time + 1

    answer = -1 if current_health <= 0 else current_health
    return answer

if __name__ == '__main__':
    bandage = [
        [5, 1, 5],
        [3, 2, 7],
        [4, 2, 7],
        [1, 1, 1]
    ]
    health = [30, 20, 20, 5]
    attacks = [
        [[2, 10], [9, 15], [10, 5], [11, 5]],
        [[1, 15], [5, 16], [8, 6]],
        [[1, 15], [5, 16], [8, 6]],
        [[1, 2], [3, 2]]
    ]
    result = [5, -1, -1, 3]

    for i in range(len(bandage)):
        if result[i] == solution(bandage[i], health[i], attacks[i]):
            print(True)
        else:
            print(False)