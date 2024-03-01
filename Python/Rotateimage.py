from typing import List


def rotateImage(matrix:List[List[int]]) -> None:
    l, r = 0, len(matrix)-1

    while l<r:
        for i in range(r-l):
            top, bottom = l, r
            # save top left
            topleft = matrix[top][l+i]

            # move bottom left  to top left

            matrix[top][l+i] = matrix[bottom- i][l]

            #move bottom right to bottom l
            matrix[bottom-i][l] = matrix[bottom][r-i]

            # move top r to bottom l
            matrix[bottom][r-1] = matrix[top+i][r]

            matrix[top+i][r] = topleft

        l+= 1
        r-= 1
