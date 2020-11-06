using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class BuilderCompany
    {

        private double totalConsumption;
        private double orderAndDeliveryOutcome;
        private int[] minDiscountBorder;
        private int[] maxDiscountBorder;
        private double[] pricePerM2;
        private double percentage;

        public BuilderCompany(double userTotalConsumption, double userOrderAndDeliveryOutcome,int []userMinDiscountBorder, int []userMaxDiscountBorder, double []userPricePerM2, double userPercentage)
        {
            this.totalConsumption = userTotalConsumption;
            this.orderAndDeliveryOutcome = userOrderAndDeliveryOutcome;
            this.minDiscountBorder = userMinDiscountBorder;
            this.maxDiscountBorder = userMaxDiscountBorder;
            this.pricePerM2 = userPricePerM2;
            this.percentage = userPercentage;
        }

        public double GetTotalConsumption()
        {
            return totalConsumption;
        }

        public void SetTotalConsumption(double userTotalConsumption)
        {
            totalConsumption = userTotalConsumption;
        }

        public double GetOrderAndDeliveryOutcome()
        {
            return orderAndDeliveryOutcome;
        }

        public void SetOrderAndDeliveryOutcome(double userOrderAndDeliveryOutcome)
        {
            orderAndDeliveryOutcome = userOrderAndDeliveryOutcome;
        }

        public int[] GetMinDiscountBorder()
        {
            return minDiscountBorder;
        }

        public void SetMinDiscountBorder(int []userMinDiscountBorder)
        {
            minDiscountBorder = userMinDiscountBorder;
        }

        public int[] GetMaxDiscountBorder()
        {
            return maxDiscountBorder;
        }

        public void SetMaxDiscountBorder(int[] userMaxDiscountBorder)
        {
            maxDiscountBorder = userMaxDiscountBorder;
        }

        public double[] GetPricesPerM2()
        {
            return pricePerM2;
        }

        public void SetPricesPerM2(double[] userPricesPerM2)
        {
            pricePerM2 = userPricesPerM2;
        }

        public double GetPercantage()
        {
            return percentage;
        }

        public void SetPercentage(double userPercantage)
        {
            percentage = userPercantage;
        }


        public double[] CountEOQ()
        {
            double[] EOQ = new double[pricePerM2.Length];

            for (int i = 0; i < EOQ.Length; i++)
            {
                EOQ[i] = Math.Round(Math.Sqrt(2 * totalConsumption * orderAndDeliveryOutcome / (pricePerM2[i] * percentage)),2);
            }
            return EOQ;

        }
        public int[] CountRealQ(double[] EOQ)
        {
            int[] realQ = new int[EOQ.Length];
            for (int i = 0; i < realQ.Length; i++)
            {
                if (EOQ[i] >= minDiscountBorder[i] && EOQ[i] <= maxDiscountBorder[i])
                {
                    realQ[i] = Convert.ToInt32(EOQ[i]);
                }
                else if (EOQ[i] < minDiscountBorder[i])
                {
                    realQ[i] = Convert.ToInt32(minDiscountBorder[i]);
                }
                else
                {
                    realQ[i] = Convert.ToInt32(maxDiscountBorder[i]);
                }
            }
            return realQ;
        }

        public double[] CountamountOfOrders(int[] realQ)
        {
            double[] amountOfOrders = new double[realQ.Length];
            for (int i = 0; i < amountOfOrders.Length; i++)
            {
                amountOfOrders[i] = Math.Round(totalConsumption / realQ[i],2);
            }
            return amountOfOrders;
        }
        public double[] CountTH(int[] realQ, double[] intNumberOfOrders)
        {
            double[] TH = new double[realQ.Length];
            for (int i = 0; i < TH.Length; i++)
            {
                if (intNumberOfOrders[i] == 0)
                {
                    TH[i] = 0;
                }
                else
                {
                    TH[i] = Math.Round(realQ[i] * percentage * pricePerM2[i] / 2, 2);
                }
            }
            return TH;
        }

        public double[] CountTS(int[] realQ, double[] intNumberOfOrders)
        {
            double[] TS = new double[realQ.Length];
            for (int i = 0; i < TS.Length; i++)
            {
                if (intNumberOfOrders[i] == 0)
                {
                    TS[i] = 0;
                }
                else
                {
                    TS[i] = Math.Round(totalConsumption * orderAndDeliveryOutcome / realQ[i], 2);
                }
            }
            return TS;
        }

        public double[] SumTHAndTS(double []TH, double []TS)
        {
            double[] sum = new double[TH.Length];

            for(int i = 0; i < TH.Length; i++)
            {
                sum[i] = Math.Round(TH[i] + TS[i],2);
            }

            return sum;
        }
        public double[] CountTotalOutcome(double[] TH, double[] TS)
        {
            double[] commonOutCome = new double[TH.Length];
            for (int i = 0; i < commonOutCome.Length; i++)
            {
                if (TH[i] == 0 && TS[i] == 0)
                {
                    commonOutCome[i] = 0;
                }
                else
                {
                    commonOutCome[i] = Math.Round(TH[i] + TS[i] + totalConsumption * pricePerM2[i], 2);
                }
            }
            return commonOutCome;
        }
        public double[] FindOrserSize(double[] intNumberOfOrders)
        {
            double[] orderSizes = new double[intNumberOfOrders.Length];
            for (int i = 0; i < orderSizes.Length; i++)
            {
                if (intNumberOfOrders[i] == 0)
                {
                    orderSizes[i] = 0;
                }
                else
                {
                    orderSizes[i] = Math.Round(totalConsumption / intNumberOfOrders[i], 2);
                }
            }
            return orderSizes;
        }

        public int FindApprOrderAmountAndOrderSizeGroup(double[] totalOutcome, double[] orderSizes, double[] intNumberOfOrders)
        {
            int index = 0;
            double minOutcome = totalOutcome[0];
            for (int i = 0; i < totalOutcome.Length; i++)
            {
                if(totalOutcome[i] == 0)
                {
                    continue;
                }
                if (totalOutcome[i] < minOutcome)
                {
                    minOutcome = totalOutcome[i];
                    index = i;
                }
            }
            return index;
        }
        public double[] FindIntNumberOfOrders(int[] realQ, double[] amountOfOrders)
        {
            double[] intNumberOfOrders = new double[realQ.Length];
            int it;
            for (int i = 0; i < intNumberOfOrders.Length; i++)
            {
                intNumberOfOrders[i] = 0;
                it = (int)amountOfOrders[i];
                if (Math.Abs(it - amountOfOrders[i]) > 0.5)
                {
                    bool flag = false;
                    do
                    {
                        if (totalConsumption % realQ[i] == 0)
                        {
                            intNumberOfOrders[i] = totalConsumption / realQ[i];
                            flag = true;
                            break;
                        }
                        else
                        {
                            realQ[i]--;
                        }

                    } while (realQ[i] >= minDiscountBorder[i]);

                    if (flag == false)
                    {
                        do
                        {
                            if (totalConsumption % realQ[i] == 0)
                            {
                                intNumberOfOrders[i] = totalConsumption / realQ[i];
                                flag = true;
                                break;
                            }
                            else
                            {
                                realQ[i]++;
                            }

                        } while (realQ[i] <= maxDiscountBorder[i]);
                    }
                }
                else
                {
                    bool flag = false;
                    do
                    {
                        if (totalConsumption % realQ[i] == 0)
                        {
                            intNumberOfOrders[i] = totalConsumption / realQ[i];
                            flag = true;
                            break;
                        }
                        else
                        {
                            realQ[i]++;
                        }

                    } while (realQ[i] <= maxDiscountBorder[i]);

                    if (flag == false)
                    {
                        do
                        {
                            if (totalConsumption % realQ[i] == 0)
                            {
                                intNumberOfOrders[i] = totalConsumption / realQ[i];
                                flag = true;
                                break;
                            }
                            else
                            {
                                realQ[i]--;
                            }

                        } while (realQ[i] >= minDiscountBorder[i]);
                    }

                }
            }
            return intNumberOfOrders;
        }
    }
}
