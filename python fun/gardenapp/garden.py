from plant import Flower, Tree


garden = [Flower("yellow"), Flower("blue"), Tree("purple"), Tree("orange")]


def status():
    for stuff in garden:
        print(stuff)
    print()


def count_plants_that_need_watering():
    counter = 0
    for stuff in garden:
        if stuff.needs_water:
            counter += 1
    return counter


def water(water_amount):
    number_of_plants_to_water = count_plants_that_need_watering()
    for stuff in garden:
        if stuff.needs_water:
            stuff.water(water_amount/number_of_plants_to_water)
    print('watering garden with ' + str(water_amount))

status()
water(40)
status()
water(70)
status()



