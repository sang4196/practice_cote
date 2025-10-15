
def pcce_no_9(wallet, bill):
    def check_input():
        if ((wallet[0] >= bill[0] and wallet[1] >= bill[1]) or
        (wallet[0] >= bill[1] and wallet[1] >= bill[0])):
            return True
        return False

    def fold():
        if bill[0] > bill[1]:
            bill[0] //= 2
        else:
            bill[1] //= 2

    answer = 0

    while not check_input():
        fold()
        answer += 1

    return answer

def pcce_no_10(mats, park):
    answer = -1
    mats.sort(reverse=True)

    def check(r, c, size):
        for i in range(size):
            if park[r + i][c:c + size].count("-1") != size:
                return False
        return True

    for mat in mats:
        for r in range(len(park) - mat + 1):
            for c in range(len(park[r]) - mat + 1):
                if park[r][c] == "-1":
                    if check(r, c, mat):
                        return mat
    return answer

def seonmul(friends, gifts):
    answer = 0

    total_dict = {f: {o: 0 for o in friends if o != f} for f in friends}
    jisu_dict = {f: 0 for f in friends}
    result_dict = {f: 0 for f in friends}

    for gift in gifts:
        f = gift.split(" ")[0]
        t = gift.split(" ")[1]
        total_dict[f][t] += 1

    for k, v in total_dict.items():
        jisu_dict[k] = (sum(total_dict[k].values()) -
                        sum(inner.get(k, 0) for inner in total_dict.values()))

    for from_p in list(total_dict.keys()):
        for to_p in list(total_dict[from_p].keys()):
            from_count = total_dict[from_p].get(to_p,0)
            to_count = total_dict[to_p].get(from_p,0)
            if from_count > to_count:
                    result_dict[from_p] += 1
            elif from_count == to_count and jisu_dict[from_p] > jisu_dict[to_p]:
                result_dict[from_p] += 1

    answer = max(result_dict.values())

    return answer

if __name__ == '__main__':
    # # PCCE 지폐 접기
    # wallet = [[30, 15], [50, 50]]
    # biil = [[26, 17], [100, 241]]
    # idx = 1
    # print(pcce_no_9(wallet[idx], biil[idx]))

    # PCCE 공원
    # mats = [5,3,2]
    # park = [
    #     ["A", "A", "-1", "B", "B", "B", "B", "-1"],
    #     ["A", "A", "-1", "B", "B", "B", "B", "-1"],
    #     ["-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1"],
    #     ["D", "D", "-1", "-1", "-1", "-1", "E", "-1"],
    #     ["D", "D", "-1", "-1", "-1", "-1", "-1", "F"],
    #     ["D", "D", "-1", "-1", "-1", "-1", "E", "-1"]
    # ]
    # print(pcce_no_10(mats, park))

    # 가장 많이 받은 선물
    # friends = [
    #     ["muzi", "ryan", "frodo", "neo"],
    #     ["joy", "brad", "alessandro", "conan", "david"],
    #     ["a", "b", "c"]
    # ]
    # gifts = [
    #     ["muzi frodo", "muzi frodo", "ryan muzi", "ryan muzi", "ryan muzi", "frodo muzi",
    #      "frodo ryan", "neo muzi"],
    #     ["alessandro brad", "alessandro joy", "alessandro conan", "david alessandro",
    #      "alessandro david"],
    #     ["a b", "b a", "c a", "a c", "a c", "c a"]
    # ]
    # idx = 2
    # print(seonmul(friends[idx], gifts[idx]))

