/**
 * Describes the meter reading object.
 */
export class MeterReading {

  public accountId: number;

  public meterReadingDateTime: any;

  public meterReadingValue: number;

  /**
   * Creates an instance of the MeterReading object.
   * @param [init] - properties to initialize.
   */
  public constructor(init?: Partial<MeterReading>) {
    Object.assign(this, init);
  }
}
